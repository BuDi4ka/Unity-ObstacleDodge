using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3f)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }


        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    // Print the elapsed time since the game started
        //    float elapsedTime = Time.time;
        //    Debug.Log("Elapsed Time: " + elapsedTime + " seconds");
        //}
    }
}
