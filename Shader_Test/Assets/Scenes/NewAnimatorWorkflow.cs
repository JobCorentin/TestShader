using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAnimatorWorkflow : MonoBehaviour
{
    Animator animator;
    private string currentState;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeAnimationState (string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);
        currentState = newState;
    }
}
