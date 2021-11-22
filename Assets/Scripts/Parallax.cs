using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float startPosition;
    public float parallaxSpeedEfect;
    public GameObject myCamera;
    private float dist=0;
    private float singleBackgroundSize;
    void Start()
    {
        startPosition = transform.position.x;
        singleBackgroundSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        dist += Mathf.Abs(myCamera.transform.position.x * (parallaxSpeedEfect/800));
        transform.position = new Vector3(startPosition - dist, transform.position.y, transform.position.z);
        
        if (transform.position.x +singleBackgroundSize-0.01f<myCamera.transform.position.x)
        {
            dist = 0;
            startPosition= myCamera.transform.position.x+ singleBackgroundSize;
            transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
        }

    }
}
