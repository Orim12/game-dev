using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    // Reference to the jumpscare sound
    public AudioClip jumpscareSound;

    // Reference to the jumpscare visual effect (e.g., a sprite renderer)
    public GameObject jumpscareVisual;

    // Function to trigger the jumpscare
    public void TriggerJumpscare()
    {
        // Play the jumpscare sound
        if (jumpscareSound != null)
        {
            AudioSource.PlayClipAtPoint(jumpscareSound, transform.position);
        }

        // Activate the jumpscare visual effect
        if (jumpscareVisual != null)
        {
            jumpscareVisual.SetActive(true);
        }
    }
}
