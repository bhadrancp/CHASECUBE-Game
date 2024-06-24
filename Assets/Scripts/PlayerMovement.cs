using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is the refference to the Rigitbody component called rb 
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewayForce = 500f;
   
    //We are using "Fixed"Update coz we are used to miss with physics
    void Update()
    {
        rb.AddForce(0 , 0 , forwardForce * Time.deltaTime , ForceMode.VelocityChange); //Add a forward Force

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime , 0, 0 , ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce( -sidewayForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
