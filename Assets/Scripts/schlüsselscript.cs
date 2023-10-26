using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            CharacterControler.schlüsselzähler++;
            
            this.gameObject.SetActive(false);
                
            }
        
        
    }
}
