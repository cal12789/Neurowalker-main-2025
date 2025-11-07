// Purpose: Teleport the player to a new empty game object. Typically add the method to a onClick button

using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    // Create Unity GameObjects to easily add new teleport locations and load them here using SerializeField

    [SerializeField] GameObject tpDorsalRootGanglionLeg;
    [SerializeField] GameObject tpSpinalCord;
    [SerializeField] GameObject tpMedulla;
    [SerializeField] GameObject tpThalamus;
    [SerializeField] GameObject tpPrimarySomatosensoryCortex;
    [SerializeField] GameObject player;
    [SerializeField] GameObject canvasObj;

    // Each of the following methods act the same. Set player position to that of the new game object (make it an empty game object)
    // This class should be for one pathway so the TP list does not get overly long

    public void TeleportPlayerTotpDorsalRootGanglionLeg() 
    {
        player.transform.position = tpDorsalRootGanglionLeg.transform.position;
        canvasObj.SetActive(false);
    } 

    public void TeleportPlayerTotpSpinalCord() {

        player.transform.position = tpSpinalCord.transform.position;
        canvasObj.SetActive(false);
    }

    public void TeleportPlayerTotpMedulla()
    {
        player.transform.position = tpMedulla.transform.position;
        canvasObj.SetActive(false);
    }

    public void TeleportPlayerTotpThalamus()
    {
        player.transform.position = tpThalamus.transform.position;
        canvasObj.SetActive(false);
    }

    public void TeleportPlayerTotpPrimarySomatosensoryCortex()
    {
        player.transform.position = tpPrimarySomatosensoryCortex.transform.position;
        canvasObj.SetActive(false);
    }

    }