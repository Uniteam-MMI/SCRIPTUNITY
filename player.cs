using UnityEngine;
using System.Collections;
public enum Feelings { Anger, Sadness };
[RequireComponent(typeof(CharacterController))]
public class player : MonoBehaviour
{
    //public int feeling;  // int qui servira à définr la couleur de Pheel
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float jumpCount = 0.0f;
    float maxJump = 2.0f;

    private Vector3 moveDirection = Vector3.zero;
    private bool IsOnTheFloor = true;

    public player()
    {

    }

    void Update()
    {

        // Controle +   anim player
        Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * speed) + (Input.GetAxis("Vertical") * Vector3.forward * speed);
        if (Input.GetButtonDown("Jump") && IsOnTheFloor)
        {
            if (!IsOnTheFloor) { return; }
            IsOnTheFloor = true;
            rigidbody.velocity = new Vector3(0, 0, 0);
            rigidbody.AddForce(new Vector3(0, 700, 0), ForceMode.Force);
        }
        else
            rigidbody.AddForce(movement, ForceMode.Force);

        /*
        CharacterController controller = GetComponent<CharacterController>();
        controller.Move(moveDirection * Time.deltaTime);

        // Apply gravity 
        moveDirection.y -= gravity * Time.deltaTime;
		
        if (!controller.isGrounded)
        {
            moveDirection.x = Input.GetAxis("Horizontal")*speed;
        }
			
        else
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal")*speed, 0.0f, Input.GetAxis("Vertical")*0.0f); 
            jumpCount = 0.0f;
        }

        if (Input.GetButton ("Sprint")) {
            moveDirection.x *= 5/2;
        }
			
*/
        if (jumpCount < maxJump)
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
                jumpCount++;
            }
        }
    }
}


