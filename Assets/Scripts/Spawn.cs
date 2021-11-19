using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Object;
    public float height;
    public int objectLiveTime=10;

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject new_object = Instantiate(Object);
            new_object.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(new_object, objectLiveTime);
            timer = Random.Range(-(maxTime/5), (maxTime / 3));
        }
        timer += Time.deltaTime;
    }
}
