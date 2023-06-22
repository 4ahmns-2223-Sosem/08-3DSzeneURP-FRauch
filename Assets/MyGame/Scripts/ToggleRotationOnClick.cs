using UnityEngine;

public class ToggleRotationOnClick : MonoBehaviour
{
    public ConstantRotation[] objectsToToggle; // Array der ConstantRotation-Skripte

    private void OnMouseDown()
    {
        foreach (ConstantRotation rotationScript in objectsToToggle)
        {
            // Umschalten des Status des ConstantRotation-Skripts
            rotationScript.enabled = !rotationScript.enabled;
        }
    }
}
