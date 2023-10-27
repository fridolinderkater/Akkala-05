using UnityEngine;
using FMODUnity;



public class CharacterControler : MonoBehaviour
{
    public static int schlüsselzähler = 0;
    public float moveSpeed = 5f;
    bool tür = false;
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference fmodEvent;
    new Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);

        //###################################################

        instance.setParameterByName("Speed", rigidbody.velocity.magnitude * 10);
        print(rigidbody.velocity.magnitude * 10);

    }
    

}