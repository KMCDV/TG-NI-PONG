using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField, Range(0, 10)] private float speed;
    [SerializeField] private ScoreHolder scoreHolder;
    private Vector2 velocity;
    private bool hasStarted;

    public Rigidbody2D Rigidbody2D
    {
        get
        {
            if (rigidbody2D == null)
                rigidbody2D = GetComponent<Rigidbody2D>();
            return rigidbody2D;
        }
    }

    private void Update()
    {
        if (hasStarted == false && Input.GetKeyUp(KeyCode.Space))
        {
            SetRandomVelocityOnStart();
        }
    }

    private void SetRandomVelocityOnStart()
    {
        Rigidbody2D.velocity = (GetRandomVectorWithoutZeroPoint() + new Vector2(Random.Range(-.2f, .2f), Random.Range(-.2f, .2f))).normalized * speed;
        velocity = Rigidbody2D.velocity;
        hasStarted = true;
    }

    private Vector2 GetRandomVectorWithoutZeroPoint()
    {
        Vector2 newVector = new Vector2();
        bool shouldXBeLessThanZero;
        shouldXBeLessThanZero = Random.Range(0, 100) % 2 == 0;
        newVector.x = shouldXBeLessThanZero ? Random.Range(-1f, -0.5f) : Random.Range(1f, 0.5f);
        shouldXBeLessThanZero = Random.Range(0, 100) % 2 == 0;
        newVector.y = shouldXBeLessThanZero ? Random.Range(-1f, -0.5f) : Random.Range(1f, 0.5f);
        return newVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D.velocity = Vector2.Reflect(velocity, collision.contacts[0].normal);
        velocity = Rigidbody2D.velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.transform.position.x > 0)
        {
            scoreHolder.SetPlayerScore(0, scoreHolder.GetPlayerScore(0) + 1);
            ResetBall();
            return;
        }
        scoreHolder.SetPlayerScore(1, scoreHolder.GetPlayerScore(1) + 1);
        ResetBall();
    }

    private void ResetBall()
    {
        Rigidbody2D.velocity = Vector2.zero;
        transform.position = Vector3.zero;
        hasStarted = false;
    }
}
