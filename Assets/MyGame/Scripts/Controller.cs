using UnityEngine;

public class Controller : MonoBehaviour
{
    public int anzahlWindraeder = 3; 
    public GameObject[] windraeder; 

    private bool[] windraederStatus; 

    private void Start()
    {
        windraederStatus = new bool[anzahlWindraeder]; 

        
        for (int i = 0; i < anzahlWindraeder; i++)
        {
            windraederStatus[i] = true; 

            
            switch (i)
            {
                case 0:
                    windraeder[i].GetComponent<Windmill>().Ausschalten(); 
                    break;
                case 1:
                    windraeder[i].GetComponent<Windmill>().Ausschalten(); 
                    break;
                case 2:
                    windraeder[i].GetComponent<Windmill>().Ausschalten(); 
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
                    windraeder[i].GetComponent<Windmill>().Ausschalten(); 
                    break;
                case 1:
                    windraeder[i].GetComponent<Windmill>().Ausschalten(); 
                    break;
                case 2:
                    windraeder[i].GetComponent<Windmill>().Ausschalten(); 
                    break;
                    
            }
        }
    }

}
