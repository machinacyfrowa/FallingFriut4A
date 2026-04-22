using UnityEngine;

public class KillBoxController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject); // Destroy the colliding object
        LevelManager.Instance.LoseLife(); // Call the LoseLife method from the LevelManager singleton instance
    }
}
