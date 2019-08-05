using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    public Animator doorAnimator;
    public bool doorIsOpen = false;

    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

}
