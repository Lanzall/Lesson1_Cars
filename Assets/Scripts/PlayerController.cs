using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Vehicle Controls")]
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    [Header("Camera Controls")]
    public Camera mainCamera;
    public Camera povCamera;
    public KeyCode switchKey;


    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //Camera Controls
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            povCamera.enabled = !povCamera.enabled;
        }
    }
}
