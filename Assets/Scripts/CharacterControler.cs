using UnityEngine;



public class CharacterControler : MonoBehaviour
{
    public static int schl�sselz�hler = 0;
    public float moveSpeed = 5f;
    bool t�r = false;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);

       //###################################################

        

    }
    

}