using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;


public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public GameObject facing;
    public CharacterController mover;
    public Vector3 moveDirectionForward;
    public Vector3 moveDirectionSide;
    public Vector3 direction;
    public float gravityScale;
    public float jumpForce;
    public Vector3 moveDirectionUp;
    public Vector3 jump;
    public bool canRotate;

    void Start()
    {
        mover = this.GetComponent<CharacterController>();
        moveSpeed = 5;

        facing = GameObject.Find("Facing");
        jumpForce = 15f;
        gravityScale = 5f;
        canRotate = true;
    }

    void Update()
    {

        
        moveDirectionForward = facing.transform.forward * Input.GetAxis("Vertical") * moveSpeed;
        moveDirectionSide = facing.transform.right * Input.GetAxis("Horizontal") * moveSpeed;
        direction = (moveDirectionForward + moveDirectionSide);


        if (mover.isGrounded == false)
        {
            jump.y = jump.y + (Physics.gravity.y * Time.deltaTime) * gravityScale;
        }
        

        if (mover.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump.y = jumpForce;
                
            }
        }

        
        
        
        //Vector3.Normalize(direction);
        mover.Move(direction * Time.deltaTime);
        mover.Move(jump * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Period) && canRotate == true)
        {
            StartCoroutine(RotateDelay());
            facing.transform.Rotate(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.Comma) && canRotate == true)
        {
            StartCoroutine(RotateDelay());
            facing.transform.Rotate(0, -90, 0);
        }
    }
    IEnumerator RotateDelay()
    {
        canRotate = false;
        yield return new WaitForSeconds(1);
        canRotate = true;
    }
}