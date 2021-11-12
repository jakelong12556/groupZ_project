using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour2 : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (AIPlayer.instance.inputReceived)
        {
            animator.SetTrigger("AttackOne");
            AIPlayer.instance.InputManager();
            AIPlayer.instance.inputReceived = false;
        }
        
        if (AIPlayer.instance.inputReceived2)
        {
            animator.SetTrigger("AttackMTwo");
            AIPlayer.instance.InputManager();
            AIPlayer.instance.inputReceived2 = false;
        }
        if (AIPlayer.instance.inputReceived3)
        {
            animator.SetTrigger("AttackSweep");
            AIPlayer.instance.InputManager();
            AIPlayer.instance.inputReceived3 = false;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
