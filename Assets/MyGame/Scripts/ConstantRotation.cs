using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    public float rotationSpeed = 10f; 
    public AudioClip rotationSound; 

    private AudioSource audioSource; 

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

   
    void Update()
    {
       
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        
        if (rotationSound != null && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(rotationSound);
        }
    }
}
