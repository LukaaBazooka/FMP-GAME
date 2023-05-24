using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grappling : MonoBehaviour
{
    public Animator animator;


    [Header("References")]
    private PlayerMovement pm;
    private HealthChecker TagCheck;

    public Transform Orientation;
    public static ToolBar toolbar;
    public Transform cam;
    public Transform gunTip;
    public LayerMask whatIsGrappleable;
    public LineRenderer lr;

    public AudioSource GrappleSound;

    [Header("Grappling")]
    public float maxGrappleDistance = 25f;
    public float grappleDelayTime = 0.5f;
    public float overshootYAxis = 2f;

    private Vector3 grapplePoint;

    [Header("Cooldown")]
    public float grapplingCd = 2.5f;
    private float grapplingCdTimer;

    [Header("Input")]
    private KeyCode Mouse1Key = KeyCode.Mouse0;

    public bool grappling;
    public static bool grapplingtwo;

    public bool ischargrappled;
    public static bool ischargrappled2;
    public Rigidbody rb;

    public int Equipped;
    private void Start()
    {
        pm = GetComponent<PlayerMovement>();

        // toolbar = GetComponent<ToolBar>();

    }

    public void Update()
    {
        // input
        grapplingtwo = grappling;
        ischargrappled2 = ischargrappled;
        Equipped = ToolBar.key;


        if (Input.GetKeyDown(Mouse1Key) && Equipped == 2) StartGrapple();
        if (Input.GetKeyDown(Mouse1Key) && Equipped == 4) StartShadow();



        if (grapplingCdTimer > 0)
            grapplingCdTimer -= Time.deltaTime;
    }

    private void LateUpdate()
    {
        if (grappling)
            lr.SetPosition(0, gunTip.position);
    }

    IEnumerator setpos(RaycastHit ray)
    {
        while (grappling)
        {
            grapplePoint = ray.rigidbody.position;
            yield return new WaitForSeconds(0);
        }
    }
    public void StartGrapple()
    {
        if (grapplingCdTimer > 0) return;


        grappling = true;

        pm.freeze = true;

        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward, out hit, maxGrappleDistance, whatIsGrappleable))
        {

            if (hit.transform.tag == "NPC")
            {

                StartCoroutine(setpos(hit));
                ischargrappled = true;
                Invoke(nameof(ExcecutePlayerGrapple), grappleDelayTime);

                hit.rigidbody.velocity = new Vector3(hit.rigidbody.velocity.x, 0f, hit.rigidbody.velocity.z);

                hit.rigidbody.AddForce(transform.up * 15 * 1.1f, ForceMode.Impulse); ;
                Debug.Log("Alive");
            }
            else
            {
                ischargrappled = false;
                grapplePoint = hit.point;

                Invoke(nameof(ExcecuteGrapple), grappleDelayTime);
            }


        }



        else
        {
            grapplePoint = cam.position + cam.forward * maxGrappleDistance;

            Invoke(nameof(StopGrapple), grappleDelayTime);
        }

        lr.enabled = true;
        lr.SetPosition(1, grapplePoint);
    }
    public void ExcecutePlayerGrapple()
    {
        animator.Play("Grapple");

        GrappleSound.Play();

        //tComponent<HealthChecker>().Damage(10f);

        pm.freeze = false;

        Vector3 lowestPoint = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);

        float grapplePointRelativeYPos = grapplePoint.y - lowestPoint.y;
        float highestPointOfArc = grapplePointRelativeYPos + 10;

        if (grapplePointRelativeYPos < 0) highestPointOfArc = 10;

        pm.JumpToPosition(grapplePoint, highestPointOfArc);

        Invoke(nameof(StopGrapple), 1f);
    }


    private Vector3 GetDirection(Transform forwardT)
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3();



        direction = forwardT.forward;

        if (verticalInput == 0 && horizontalInput == 0)
            direction = forwardT.forward;

        return direction.normalized;
    }
    public void StartShadow()
    {
        Debug.Log("HEYA");



        Transform forwardT;


        forwardT = Orientation; /// where you're facing (no up or down)

        Vector3 direction = GetDirection(forwardT);

        Vector3 forceToApply = direction * 120 + Orientation.up * -1;


        rb.useGravity = false;

        delayedForceToApply = forceToApply;
        StartCoroutine(DelayedDashForce());

    }
    private Vector3 delayedForceToApply;
    private IEnumerator DelayedDashForce()
    {
        StartCoroutine(stuff());

        animator.Play("Shadowrush");
        animator.SetBool("Attacking", true);

        rb.velocity = Vector3.zero;

        yield return new WaitForSeconds(0.3f);
        animator.SetBool("Attacking", false);

    }
      
    private IEnumerator stuff()
    {
        for (int i = 0; i < 220; i++)
        {

            rb.AddForce(delayedForceToApply, ForceMode.Acceleration);
            yield return new WaitForSeconds(0.0001f);
        }

    }

    public void ExcecuteGrapple()
    {
        animator.Play("Grapple");

        GrappleSound.Play();

        //tComponent<HealthChecker>().Damage(10f);

        pm.freeze = false;

        Vector3 lowestPoint = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);

        float grapplePointRelativeYPos = grapplePoint.y - lowestPoint.y;
        float highestPointOfArc = grapplePointRelativeYPos + overshootYAxis;

        if (grapplePointRelativeYPos < 0) highestPointOfArc = overshootYAxis;

        pm.JumpToPosition(grapplePoint, highestPointOfArc);

        Invoke(nameof(StopGrapple), 1f);
    }

    public void StopGrapple()
    {
        pm.freeze = false;

        grappling = false;

        grapplingCdTimer = grapplingCd;

        lr.enabled = false;
    }

    public void OnObjectTouch()
    {
        ///if (pm.activeGrapple) StopGrapple();
    }


    public bool IsGrappling()
    {
        return grappling;
    }

    public Vector3 GetGrapplePoint()
    {
        return grapplePoint;
    }

    /*
    void some()
    {
        // Mode - Freeze
        if (freeze)
        {
            state = MovementState.freeze;
            rb.velocity = Vector3.zero;
            moveSpeed = 0f;
        }

        else if (activeGrapple)
        {
            state = MovementState.grappling;
            moveSpeed = sprintSpeed;
        }
    }

    // Uses Vector Maths to make the player jump exactly to a desired position
    private bool enableMovementOnNextTouch;
    public void JumpToPosition(Vector3 targetPosition, float trajectoryHeight)
    {
        //activeGrapple = true;

        velocityToSet = CalculateJumpVelocity(transform.position, targetPosition, trajectoryHeight);
        Invoke(nameof(SetVelocity), 0.1f);

        Invoke(nameof(ResetRestrictions), 3f);
        enableMovementOnNextTouch = true;
    }
    private Vector3 velocityToSet;
    private void SetVelocity()
    {
        rb.velocity = velocityToSet;
        print("velocityToSet: " + velocityToSet + " velocity: " + rb.velocity);
    }

    public void ResetRestrictions()
    {
        //activeGrapple = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (enableMovementOnNextTouch)
        {
            enableMovementOnNextTouch = false;
            ResetRestrictions();

            GetComponent<Grappling_MLab>().StopGrapple();
        }
    }

    */
}
