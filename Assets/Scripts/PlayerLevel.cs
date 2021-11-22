using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public static int level = 1;
    void Start()
    {
        level = 1;
    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Level: " + level.ToString();
    }
}
