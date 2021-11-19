using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public int energyNeededToGetLevel=400;
    public int additionalEnergyNeededToGetNextLevel = 50;
    public int energyAfterHittingNextLevel = 250;
    public float playerScaleAfterHittingNextLevel = 1.5f;
    static public Vector3 scaleOnStart;
    private void Start()
    {
        scaleOnStart=transform.localScale;
    }
    void Update()
    {
        if (Energy.energy > energyNeededToGetLevel)
        {
            transform.localScale = new Vector3(transform.localScale.x + playerScaleAfterHittingNextLevel,
                transform.localScale.y + playerScaleAfterHittingNextLevel, transform.localScale.z);
            Energy.energy = energyAfterHittingNextLevel;
            energyNeededToGetLevel += additionalEnergyNeededToGetNextLevel-50;
            PlayerLevel.level++;
        }
    }
}
