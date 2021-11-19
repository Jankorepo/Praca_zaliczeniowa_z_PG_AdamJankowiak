using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D my_rigidbody;
    private float flightStability = 100;
    private float position;
    public GameMenager gameMenager;
    void Start()
    {
        my_rigidbody = GetComponent<Rigidbody2D>();
        position = transform.position.x;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && Energy.energy > 0.1 && flightStability == 100)
        {
            my_rigidbody.velocity = Vector2.up * velocity;
            Energy.energy -= 9+PlayerLevel.level;
        }
        else if (Input.GetKeyDown(KeyCode.A) && flightStability == 100)
        {
            position = position - 0.5f;

        }
        else if (Input.GetKeyDown(KeyCode.D) && flightStability == 100)
        {
            position = position + 0.5f;
        }
        if (flightStability < 100)
        {
            flightStability += 1f;
        }
        if (Energy.energy < 0)
        {
            Energy.energy = 0;
        }
        if (PlayerLevel.level==11)
        {
            gameMenager.GameWon();
        }
        transform.position = new Vector3(position, transform.position.y, transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
        if (collision.gameObject.CompareTag("Small_energy_bonus"))
        {
            Destroy(collision.gameObject,0.05f);
            Score.score++;
            Energy.energy += 25;
        }
        if (collision.gameObject.CompareTag("Medium_energy_bonus"))
        {
            Destroy(collision.gameObject, 0.05f);
            Score.score++;
            Energy.energy += 40;
        }
        if (collision.gameObject.CompareTag("Large_energy_bonus"))
        {
            Destroy(collision.gameObject, 0.05f);
            Score.score++;
            Energy.energy += 60;
        }
        if (collision.gameObject.CompareTag("Life"))
        {
            Destroy(collision.gameObject, 0.05f);
            Score.score+=10;
            Energy.energy += 100;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var enemySize = collision.gameObject.transform.parent.transform.localScale.x;
            if(enemySize>transform.localScale.x/2)
            {
                flightStability = 20;
                if (enemySize > transform.localScale.x*0.75)
                    flightStability = -50;
            }
            Rigidbody2D gameObjectRB = collision.gameObject.transform.parent.gameObject.AddComponent<Rigidbody2D>();
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            gameMenager.GameOver();
        }
    }
}
