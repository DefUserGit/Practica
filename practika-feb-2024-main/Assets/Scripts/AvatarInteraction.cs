using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInteraction : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Start()
    {
        animator.speed = 0;
    }

    public void AnimationOnOff()
    {
        if (animator.speed != 0 && !animator.GetCurrentAnimatorStateInfo(0).IsName("Knyaz animation") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {
            animator.speed = 0;
        }
        else
        {
            if (animator.speed <= 0)
                animator.speed = 0.5f;
            else if (animator.speed > 0)
                animator.speed = 0;
        }
    }
}