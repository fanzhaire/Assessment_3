using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerAnimations : MonoBehaviour
{
    public Animator pacStudentAnimator;
    public Animator powerPelletsAnimator;
    public Animator walkingStateAnimator;
    public Animator scaredStateAnimator;
    public Animator recoveringStateAnimator;
    public Animator deadStateAnimator;

    void Start()
    {
        if (pacStudentAnimator != null) pacStudentAnimator.enabled = false;
        if (powerPelletsAnimator != null) powerPelletsAnimator.enabled = false;
        if (walkingStateAnimator != null) walkingStateAnimator.enabled = false;
        if (scaredStateAnimator != null) scaredStateAnimator.enabled = false;
        if (recoveringStateAnimator != null) recoveringStateAnimator.enabled = false;
        if (deadStateAnimator != null) deadStateAnimator.enabled = false;
    }

    public void OnPlayButtonClicked()
    {
        if (pacStudentAnimator != null)
        {
            pacStudentAnimator.enabled = true;
            pacStudentAnimator.SetTrigger("Play");
        }
        if (powerPelletsAnimator != null)
        {
            powerPelletsAnimator.enabled = true;
            powerPelletsAnimator.SetTrigger("Play");
        }
        if (walkingStateAnimator != null)
        {
            walkingStateAnimator.enabled = true;
            walkingStateAnimator.SetTrigger("Play");
        }
        if (scaredStateAnimator != null)
        {
            scaredStateAnimator.enabled = true;
            scaredStateAnimator.SetTrigger("Play");
        }
        if (recoveringStateAnimator != null)
        {
            recoveringStateAnimator.enabled = true;
            recoveringStateAnimator.SetTrigger("Play");
        }
        if (deadStateAnimator != null)
        {
            deadStateAnimator.enabled = true;
            deadStateAnimator.SetTrigger("Play");
        }
    }
}

