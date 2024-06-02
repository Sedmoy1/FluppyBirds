using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float Force = 100f;
    
   // public AudioSource MainTheme;
   // public AudioSource Sound1;
//   public AudioSource Sound1 LoopExpression;

   // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector2.up * Force);
                
         
        } 
    }
}
