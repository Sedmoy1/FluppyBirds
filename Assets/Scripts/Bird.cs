using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float Force = 100f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector2.up * Force);
        }
    }
}
