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
        if (CheckIfKeyIsHeldDown(upKey))
        {
            Rigidbody2D.velocity = Vector2.up * speed;
        }
        else if (CheckIfKeyIsHeldDown(downKey))
        {
            Rigidbody2D.velocity = Vector2.down * speed;
        }
        else
        {
            Rigidbody2D.velocity = Vector2.zero;
        }
    }

    public bool CheckIfKeyIsHeldDown(KeyCode k) => Input.GetKey(k);

}
