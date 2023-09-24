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

    private bool animationTriggered = false;  

    void Start()
    {
        DisableAutoPlay();
    }

    void DisableAutoPlay()
    {
        if (pacStudentAnimator != null) pacStudentAnimator.StopPlayback();
        if (powerPelletsAnimator != null) powerPelletsAnimator.StopPlayback();
        if (walkingStateAnimator != null) walkingStateAnimator.StopPlayback();
        if (scaredStateAnimator != null) scaredStateAnimator.StopPlayback();
        if (recoveringStateAnimator != null) recoveringStateAnimator.StopPlayback();
        if (deadStateAnimator != null) deadStateAnimator.StopPlayback();
    }

    public void OnPlayButtonClicked()
    {
        if (!animationTriggered)  
        {
            EnableAndPlayAnimators();
            animationTriggered = true;  
        }
    }

    void EnableAndPlayAnimators()
    {
        TriggerAnimator(pacStudentAnimator);
        TriggerAnimator(powerPelletsAnimator);
        TriggerAnimator(walkingStateAnimator);
        TriggerAnimator(scaredStateAnimator);
        TriggerAnimator(recoveringStateAnimator);
        TriggerAnimator(deadStateAnimator);
    }

    void TriggerAnimator(Animator animator)
    {
        if (animator != null)
        {
            animator.enabled = true;  
            animator.SetTrigger("PlayAnimation");  
        }
    }
}
