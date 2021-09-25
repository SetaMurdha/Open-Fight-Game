using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator animator;
    int hashAttack1;
    int hashWalk_forward;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hashAttack1 = Animator.StringToHash("attack1");
        hashWalk_forward = Animator.StringToHash("walk_forward");
    }

    // Update is called once per frame
    void Update()
    {
        bool key_attack1 = Input.GetKey("j");
        bool keyWalk_forward = Input.GetKey("d");

        bool attack1 = animator.GetBool(hashAttack1);
        bool walk_forward = animator.GetBool(hashWalk_forward);

        if(!attack1 && key_attack1){
            animator.SetBool(hashAttack1, true);
        }
        if(attack1 && !key_attack1){
            animator.SetBool(hashAttack1, false);
        }

        if(!walk_forward && keyWalk_forward){
            animator.SetBool(hashWalk_forward, true);
        }
        if(walk_forward && !keyWalk_forward){
            animator.SetBool(hashWalk_forward, false);
        }
    }
}
