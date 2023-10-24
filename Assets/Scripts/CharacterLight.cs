using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterLight : MonoBehaviour
{
    public float lightrange;

    public float startRange = 20f;
    public float lightSpeed = 0.02f;

    public bool verloren = false;

    float endRange = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
        


    }

    // Update is called once per frame
    void Update()
    {
        lightrange = startRange - Time.fixedTime;
        if (lightrange == 0f)
        {
            verloren = true;
            
        }
    }
}
