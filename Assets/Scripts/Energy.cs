using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public int startEnergyLevel = 150;
    public static int energy;
    
    // Start is called before the first frame update
    private void Start()
    {
        energy = startEnergyLevel;
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Energy: " + energy.ToString();
    }
}
