using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterLight : MonoBehaviour
{
    public float lightrange;
    public float lifetime = 10f;

    public bool verloren = false;

    bool load;

    float time;

    private float timer = 0f;
    private int count;


    // Start is called before the first frame update
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {
        if (!load)
        {


            lightrange = lifetime - count;

            if (lightrange == 0f)
            {
                verloren = true;
                Debug.Log("verloren");


            }
        }
        else
        {
            if (lightrange < lifetime)
            {
                
                
                lightrange =  count;
            }
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
            count++;
            timer = 0f; // Zurücksetzen des Timers für die nächste Sekunde


        }
    }
    //################################################################################
}
