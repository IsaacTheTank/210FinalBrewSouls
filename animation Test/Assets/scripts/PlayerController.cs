using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Animator myAnim;
   
	// Use this for initialization
	void Start () {
        myAnim = GetComponent<Animator>();
       
	}

    // Update is called once per frame
    void Update() {
        myAnim.SetInteger("isIdle", 0);
        myAnim.SetInteger("isRunning", 0);
        myAnim.SetInteger("isAttacking", 0);
        myAnim.SetInteger("isDodging", 0);
        myAnim.SetInteger("isBacking", 0);
        myAnim.SetInteger("isRight", 0);
        myAnim.SetInteger("isLeft", 0);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetInteger("isDodging", 2);
                
        }
        else
        {


            myAnim.SetInteger("isIdle", 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnim.SetInteger("isRunning", 1);
        }
        else
        {
            myAnim.SetInteger("isIdle", 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myAnim.SetInteger("isBacking", 4);
        }
        else
        {


            myAnim.SetInteger("isIdle", 0);

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            myAnim.SetInteger("isAttacking", 3);
        }
        else
        {


            myAnim.SetInteger("isIdle", 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myAnim.SetInteger("isLeft", 6);
        }
        else
        {


            myAnim.SetInteger("isIdle", 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myAnim.SetInteger("isRight", 5);
        }
        else
        {


            myAnim.SetInteger("isIdle", 0);
        }
    

    }
}
