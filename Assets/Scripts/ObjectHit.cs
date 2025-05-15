using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log("Collision detected with: " + other.gameObject.name);
            gameObject.tag = "Hit";
        }
        
    }
}
