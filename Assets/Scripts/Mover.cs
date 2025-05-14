using UnityEngine;

public class Mover : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * 0.1f;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * 0.1f;
        transform.Translate(xValue, yValue, zValue);
    }
}


