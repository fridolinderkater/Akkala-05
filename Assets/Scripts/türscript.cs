using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class türscript : MonoBehaviour
{
    public DoorAnimation animation;
    public GameObject Door1;
    [SerializeField] private int requiredKeys;
    //public BoxCollider boxCollider;
    void Start()
    {
        animation = GetComponent<DoorAnimation>();
        //boxCollider = Door1.GetComponent<boxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player") && CharacterControler.schlüsselzähler == requiredKeys)
        {

            RuntimeManager.PlayOneShot("event:/Door1");
            animation.openDoorsAnimation();
            Door1.GetComponent<BoxCollider>().enabled = false;

            

        }


    }
}
