using FischlWorks_FogWar;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterLight : MonoBehaviour
{
    public int lightrange;
    public int lifetime = 10;

    public bool verloren = false;

    bool load;

    float time;

    private float timer = 0f;
    private int count;

    public csFogWar fogWar;


    // Start is called before the first frame update
    void Start()
    {

        
        count = lifetime;

    }

    // Update is called once per frame
    void Update()
    {



        csFogWar.FogRevealer firstFogRevealer = fogWar._FogRevealers[0];
        firstFogRevealer.sightRange =  lightrange;


        lightrange =  count;

            if (lightrange == 0f)
            {
                verloren = true;
                Debug.Log("verloren");


            }
        
        
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("lightarea"))
        {
            Debug.Log("getriggert");
            load = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("lightarea"))
        {
            load = false;
        }
    }
    //##############################################################################
    //Zeit
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer >= 1f)
        {
            if (load)
            {
                if (lightrange < lifetime)
                {
                    count++;
                }
                    
            }
            else
            {
                count--;
            }
            
            timer = 0f; // Zurücksetzen des Timers für die nächste Sekunde


        }
    }
    //################################################################################
}
