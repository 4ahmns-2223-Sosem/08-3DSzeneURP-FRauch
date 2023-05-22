using UnityEngine;

public class Windmill : MonoBehaviour
{
    public float windStrengthThreshold = 5f; // Mindeststärke des Windes, um den Sound abzuspielen
    public AudioClip windSound; // Sound-Clip für den Wind

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
        if (GetWindStrength() >= windStrengthThreshold)
        {
            
            if (!audioSource.isPlaying)
            {
                
                audioSource.PlayOneShot(windSound);
            }
        }
        else
        {
     
            if (audioSource.isPlaying)
            {
               
                audioSource.Stop();
            }
        }
    }

    private float GetWindStrength()
    {
 
        return Random.Range(0f, 10f);
    }
}