using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Speed = 20;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
