using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Closing collision");
    }
}
