using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour
{
    float creepSpeed = 0.2f;
    float runningSpeed = 1.5f;
    float speed = 0.6f;
    float rotSpeed = 80;
    float rot = 0f;
    float runningRot = 120;
    float gravity = 8;
    float sitSpeed = 0;
  
    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anim;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
       
    }


    private void Update()
    {

        Movement();
        Movement2();
        Movement3();
        Movement4();
        //Getinput();

    }

    void Movement()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
               
            


            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                if (anim.GetBool("running") == true)
                {
                    return;
                }
                else if (anim.GetBool("condition") == false)
                {



                    anim.SetInteger("condition", 0);
                    moveDir = new Vector3(0, 0, 0);
                }
            }

        }
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);





    }




    void Movement2()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {

                anim.SetInteger("condition", 2);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= runningSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }


            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);



            }



                rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rot, 0);

            moveDir.y -= gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime);

            

        }
    }




    void Movement3()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {

                anim.SetInteger("condition", 3);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= creepSpeed;
                moveDir = transform.TransformDirection(moveDir);
                

            }


            if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);



            }



            rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rot, 0);

            moveDir.y -= gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime);



        }
    }



    void Movement4()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.S))
            {

                anim.SetInteger("condition", 4);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= sitSpeed;
                moveDir = transform.TransformDirection(moveDir);

            }


            if (Input.GetKeyUp(KeyCode.S))
            {
                anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);



            }



            rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rot, 0);

            moveDir.y -= gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime);



        }
    }



}


