using System;
using UnityEngine;

public class Windmill : MonoBehaviour
{
    public float windStrengthThreshold = 5f; 
    public AudioClip windSound; 

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
 
    // return System.Random.Range(0f, 10f); 
   }

    internal void Ausschalten()
    {
        throw new NotImplementedException();
    }
}