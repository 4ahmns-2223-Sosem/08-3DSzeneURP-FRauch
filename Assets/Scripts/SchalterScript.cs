using UnityEngine;
using UnityEngine.UI;

public class SchalterScript : MonoBehaviour
{
    public WindradController windradController; 

    private Button schalterButton;

    private void Start()
    {
        schalterButton = GetComponent<Button>();
        schalterButton.onClick.AddListener(AusschaltenDerWindraeder);
    }

    private void AusschaltenDerWindraeder()
    {
        windradController.AusschaltenWindraeder();
    }
}
