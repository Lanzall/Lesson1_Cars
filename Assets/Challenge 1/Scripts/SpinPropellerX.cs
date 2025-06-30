using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float PropellerSpeed = 2.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, PropellerSpeed);
    }
}
