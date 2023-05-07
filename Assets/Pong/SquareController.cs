using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField, Range(0, 10)] private float speed;
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;

    public Rigidbody2D Rigidbody2D
    {
        get
        {
            if(rigidbody2D == null)
                rigidbody2D = GetComponent<Rigidbody2D>();
            return rigidbody2D;
        }
    }

    // Update is called once per frame
    void Update()
    {
         Rigidbody2D.velocity = new Vector2(speed * Input.GetAxis("Horizontal"),  speed * Input.GetAxis("Vertical"));
    }

}
