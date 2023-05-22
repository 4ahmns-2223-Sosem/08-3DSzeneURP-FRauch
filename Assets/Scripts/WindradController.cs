using UnityEngine;

public class WindradController : MonoBehaviour
{
    public int anzahlWindraeder = 3; 
    public GameObject[] windraeder; 

    private bool[] windraederStatus; 

    private void Start()
    {
        windraederStatus = new bool[anzahlWindraeder]; 

        
        for (int i = 0; i < anzahlWindraeder; i++)
        {
            windraederStatus[i] = true; /

            
            switch (i)
            {
                case 0:
                    windraeder[i].GetComponent<WindradScript>().Ausschalten(); 
                    break;
                case 1:
                    windraeder[i].GetComponent<WindradScript>().Ausschalten(); 
                    break;
                case 2:
                    windraeder[i].GetComponent<WindradScript>().Ausschalten(); // Beispielaufruf für das dritte Windrad-Skript
                    break;
               
            }
        }
    }
    public void AusschaltenWindraeder()
    {
        for (int i = 0; i < anzahlWindraeder; i++)
        {
            windraederStatus[i] = false; 

         
            switch (i)
            {
                case 0:
                    windraeder[i].GetComponent<WindradScript>().Ausschalten(); 
                    break;
                case 1:
                    windraeder[i].GetComponent<WindradScript>().Ausschalten(); 
                    break;
                case 2:
                    windraeder[i].GetComponent<WindradScript>().Ausschalten(); 
                    break;
                    
            }
        }
    }

}
