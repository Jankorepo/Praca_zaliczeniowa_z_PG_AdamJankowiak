using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public int startEnergyLevel = 150;
    public static int energy;
    private void Start()
    {
        energy = startEnergyLevel;
    }
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Energy: " + energy.ToString();
    }
}
