using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class koordinatenFürSound : MonoBehaviour
{
    public float höhe;
    float startposition;
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference fmodEvent;
    // Start is called before the first frame update
    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
        startposition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
        höhe = transform.position.z - startposition - 3;
        instance.setParameterByName("Tiefe", höhe);
    }
}
