using UnityEngine;
using System.Collections;
 
public class PlayerMovement : MonoBehaviour 
{
 
    public float playerSpeed = 6;
    public CharacterController characterController;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;
        characterController.Move(playerSpeed * Time.deltaTime * move);
    }
}