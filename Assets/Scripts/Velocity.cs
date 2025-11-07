// Purpose: Add to a GameObject with a rigidbody to give it velocity as desrcibed below

using UnityEngine;

public class Velocity : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the rigidbody component of the sphere
        rb = GetComponent<Rigidbody>();

        //Adds velocity of 10 units in the negative z direction to rb
        rb.velocity = new Vector3(0,0,-10); 
    }
}