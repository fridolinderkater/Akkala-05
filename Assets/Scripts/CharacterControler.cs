using UnityEngine;



public class CharacterControler : MonoBehaviour
{
    public static int schlüsselzähler = 0;
    public float moveSpeed = 5f;
    bool tür = false;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);

       //###################################################

        

    }
    

}