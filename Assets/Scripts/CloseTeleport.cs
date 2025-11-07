// Purpose: This is a simple script to close the teleport menu

using UnityEngine;

public class CloseTeleport : MonoBehaviour
{
    [SerializeField] GameObject TeleportMenu;

    // Update is called once per frame
    void Update()
    {
        // Checks every frame for if the Start button on the Oculus Quest 2 has been pressed down
        if (OVRInput.GetDown(OVRInput.RawButton.Start))
        {
            // If it detects a button press it will set the teleport menu canvas hidden
            TeleportMenu.SetActive(false);
        }
    }
}
