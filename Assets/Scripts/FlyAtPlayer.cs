using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform trigger;
    Vector3 triggerPosition;
    [SerializeField] float speed = 0.1f;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        
        triggerPosition = trigger.transform.position;
    }

    void Update()
    {
        MoveToPlayer(); 
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == triggerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        transform.position =
        Vector3.MoveTowards(transform.position, triggerPosition, speed * Time.deltaTime);
    }
}
