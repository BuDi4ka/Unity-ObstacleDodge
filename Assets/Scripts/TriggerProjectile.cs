using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;
    bool hasActived = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && hasActived == false)
        {
            foreach (GameObject projectile in projectiles)
            {
                if (projectile != null)
                {
                    projectile.SetActive(true);
                }
                else
                {
                    Debug.LogWarning("Projectile reference is null.");
                }
            }
            hasActived = true;
        }
    }

    private void Update()
    {
        Debug.Log("Activated - " + hasActived);
    }
}
