using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class schlüsselscript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        
            if (other.CompareTag("Player"))
            {
            RuntimeManager.PlayOneShot("event:/Key1");
            CharacterControler.schlüsselzähler++;
            
            this.gameObject.SetActive(false);
                
            }
        
        
    }
}
