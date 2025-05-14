using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int score = 0; // Variable to hold the score

    private void OnCollisionEnter(Collision collision)
    {
        score += 1;

        Debug.Log("Score: " + score); // Log the score to the console
    }
}
