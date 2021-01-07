using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator); 
    }

    // Update is called once per frame
    void Update()
    {   
        bool walkActive = Input.GetButton("walk");
        bool isWalking = animator.GetBool("isWalking");
        bool attack = Input.GetButton("attack");
        bool isAttacking = animator.GetBool("isAttacking");
        if(!isWalking && walkActive){
            animator.SetBool("isWalking", true);
        }
        if(isWalking && !walkActive){
            animator.SetBool("isWalking", false);
        }
        if (attack && !isAttacking){
            animator.SetBool("isAttacking", true);
        }
        if(isAttacking && !attack){
            animator.SetBool("isAttacking", false);
        }

    }
}
