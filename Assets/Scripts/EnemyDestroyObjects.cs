using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyObjects : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Small_energy_bonus"))
        {
            Destroy(collision.gameObject, 0.05f);
        }
        if (collision.gameObject.CompareTag("Medium_energy_bonus"))
        {
            Destroy(collision.gameObject, 0.05f);
        }
        if (collision.gameObject.CompareTag("Large_energy_bonus"))
        {
            Destroy(collision.gameObject, 0.05f);
        }
    }
}
