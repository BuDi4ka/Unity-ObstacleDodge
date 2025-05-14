using UnityEngine;


public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    bool hasDropped = false;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false; // Disable the mesh renderer at the start
        myRigidBody.useGravity = false; // Disable gravity at the start
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Time.time > timeToWait && !hasDropped)
        {
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<MeshRenderer>().enabled = true;

            Invoke(nameof(FreezeObject), 3f);

            hasDropped = true;
        }


        if (Input.GetKeyDown(KeyCode.T))
        {
            // Print the elapsed time since the game started
            float elapsedTime = Time.time;
            Debug.Log("Elapsed Time: " + elapsedTime + " seconds");
        }
    }
    void FreezeObject()
    {
        myRigidBody.constraints = RigidbodyConstraints.FreezePositionY |
                                  RigidbodyConstraints.FreezeRotationX |
                                  RigidbodyConstraints.FreezeRotationZ;
    }
}
