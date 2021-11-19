using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioSource crash;
    public AudioSource getLevel;
    private int nextLevel=2;
    public void Update()
    {
        if(PlayerLevel.level==nextLevel)
        {
            getLevel.Play();
            nextLevel++;
        }
        if(PlayerLevel.level==1)
        {
            nextLevel = 2;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            crash.Play();
        }
    }
}
