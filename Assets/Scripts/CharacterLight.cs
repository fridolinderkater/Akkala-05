using FischlWorks_FogWar;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterLight : MonoBehaviour
{
    public float currentLightrange;
    public float maxLightrange = 10f;
    public int lifetime = 10;


    public bool verloren = false;

    public bool load;

    float time;

    private float timer = 0f;
    private int count;

    public float increaseSpeed = 10f;
    public float decreaseSpeed = 0.01f;

    public csFogWar fogWar;

    public GameObject gameover;
    public GameObject win;
    public GameObject overlay;


    // Start is called before the first frame update
    void Start()
    {
        count = lifetime;
        currentLightrange = maxLightrange - 0.5f;
        
    }

    // Update is called once per frame
    void Update()
    {

        
        Debug.Log(currentLightrange);
        //lightrange =  count;
        //SightCalculation();


        if (currentLightrange <= 0f && verloren == false)
        {
            verloren = true;
            Debug.Log("verloren");
            overlay.SetActive(true);
            gameover.SetActive(true);
        }

        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("lightarea"))
        {
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ziel"))
        {
            overlay.SetActive(true);
            win.SetActive(true);
            
        }
    }
    //##############################################################################
    //Zeit
    void FixedUpdate()
    {
        csFogWar.FogRevealer firstFogRevealer = fogWar._FogRevealers[0];
        firstFogRevealer.sightRange =  currentLightrange;
        timer += Time.fixedDeltaTime;
        SightCalculation();
        // if (timer >= 1f)
        // {
        //     if (load)
        //     {
        //         if (currentLightrange < lifetime)
        //         {
        //             count++;
        //         }
                    
        //     }
        //     else
        //     {
        //         count--;
        //     }
            
        //     timer = 0f; // Zur�cksetzen des Timers f�r die n�chste Sekunde


        // }
    }




    private void SightCalculation()
    {
        if(load && currentLightrange < maxLightrange)
        {
            currentLightrange += increaseSpeed * Time.deltaTime;
        }
        else if (!load)
        {
            currentLightrange -= decreaseSpeed * Time.deltaTime;
        }
        currentLightrange = Mathf.Clamp(currentLightrange, 0, 10f); //lightrange bleibt im vorgeschriebenen bereich
    }
    //################################################################################
}
