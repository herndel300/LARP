using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBehavior : MonoBehaviour
{
    public Animator animator;
    public string animationClipName;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 0.75F;
    }

    // Update is called once per frame
    void Update()
    {
        animator.Play(animationClipName);
    }
}
