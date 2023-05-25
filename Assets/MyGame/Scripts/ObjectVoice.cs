using UnityEngine;
using UnityEditor;

public class ObjectVoice : MonoBehaviour
{
    public GameObject player;
    public GameObject objectToExplain;
    public AudioSource voiceSource;
    public AudioClip objectExplanationClip;

    private bool playerInRange = false;

    private void Update()
    {
     
        if (playerInRange)
        {

            if (!voiceSource.isPlaying)
            {
      
                voiceSource.clip = objectExplanationClip;
                voiceSource.Play();
            }
        }
        else
        {
        
            if (voiceSource.isPlaying)
            {
  
                voiceSource.Stop();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
  
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }
}