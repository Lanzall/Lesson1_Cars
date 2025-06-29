using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //Move to vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
