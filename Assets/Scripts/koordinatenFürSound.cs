using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koordinatenFürSound : MonoBehaviour
{
    public float höhe;
    float startposition;
    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        höhe = transform.position.z - startposition;
    }
}
