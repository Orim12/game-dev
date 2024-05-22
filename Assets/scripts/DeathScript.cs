using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    // Reference to any other scripts/components that should react to the player's death
    public GameObject deathEffect; // Particle effect, explosion, etc.
    public GameObject gameOverUI; // UI element to show when the player dies

    // Function to handle player death
    public void Die()
    {
        // Instantiate death effect if specified
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }

        // Disable player GameObject (or any components like control scripts, etc.)
        gameObject.SetActive(false);

        // Show game over UI if specified
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }
    }
}
