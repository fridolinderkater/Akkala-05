using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;

    public Animator lAnimator;
    public Animator rAnimator;


    void Start()
    {
        lAnimator = leftDoor.GetComponent<Animator>();
        rAnimator = rightDoor.GetComponent<Animator>();

    }

    public void openDoorsAnimation()
    {
        lAnimator.SetBool("Open01", true);
        rAnimator.SetBool("Open01", true);
    }


}
