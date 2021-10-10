using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Climber climber = null;
    public OVRInput.Controller controller = OVRInput.Controller.None;

    public GameObject currentPoint = null;

    public Vector3 Delta { private set; get; } = Vector3.zero;

    private Vector3 lastPosition = Vector3.zero;

    public List<GameObject> contactPoints = new List<GameObject>();
    private MeshRenderer meshRenderer = null;

    public Vector3 passFloatMove;

    
    public GameObject brokenBubble;

    private void Awake()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    private void Start()
    {
        lastPosition = transform.position;
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller))
        {
            GrabPoint();
            
        
            //Instantiate(handBubble, transform.position, transform.rotation);
        
        }

        

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, controller))
        {
            ReleasePoint();

            //Destroy(handBubble);
        }

        
    }

    private void FixedUpdate()
    {
        lastPosition = transform.position;
    }

    private void LateUpdate()
    {
        Delta = lastPosition - transform.position;
    }

    private void GrabPoint()
    {

        currentPoint = Utility.GetNearest(transform.position, contactPoints);
        if (currentPoint)
        {
            climber.SetHand(this);
            meshRenderer.enabled = false;

            // Xu: We want to tell the BubbleFloat script who the climber is.
            currentPoint.GetComponent<BubbleFloat>().SetClimber(climber);

            //Instantiate(brokenBubble, currentPoint.transform);
        }
    }

    public void ReleasePoint()
    {
        if (currentPoint)
        {
            //climber
            climber.ClearHand();
            meshRenderer.enabled = true;

            // Xu: We want to clear the reference
            currentPoint.GetComponent<BubbleFloat>().SetClimber(null);
        }
        currentPoint = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        AddPoint(other.gameObject);
        other.GetComponent<BubbleFloat>().isGrabbed = true;
        passFloatMove = other.GetComponent<BubbleFloat>().floatMove;
    }

    private void AddPoint(GameObject newObject)
    {
        if (newObject.CompareTag("ClimbPoint"))
        {
            contactPoints.Add(newObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        RemovePoint(other.gameObject);
        other.GetComponent<BubbleFloat>().isGrabbed = false;
    }

    private void RemovePoint(GameObject newObject)
    {
        if (newObject.CompareTag("ClimbPoint"))
        {
            contactPoints.Remove(newObject);
        }
    }
}