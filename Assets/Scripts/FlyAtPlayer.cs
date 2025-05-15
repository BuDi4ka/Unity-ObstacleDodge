using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float speed = 0.1f;
    
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, speed * Time.time);
    }
}
