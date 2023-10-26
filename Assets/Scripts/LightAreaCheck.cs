using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAreaCheck : MonoBehaviour
{
    public GameObject player;
    public CharacterLight lightCtrl;
    public SphereCollider sphereCollider;

    void Start()
    {
        lightCtrl = GetComponentInParent<CharacterLight>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRadius();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("lightarea"))
        {
            lightCtrl.load = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("lightarea"))
        {
            lightCtrl.load = false;
        }
    }

    private void UpdateRadius()
    {
        sphereCollider.radius = lightCtrl.lightrange * 1.1f;

    }
}
