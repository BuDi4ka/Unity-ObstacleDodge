using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        Debug.Log("Collision detected with: " + other.gameObject.name);
    }
}
