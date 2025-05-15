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
        MoveToPlayer(); 
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        transform.position =
        Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
