using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionController : MonoBehaviour, ICollectible
{
    public HealthPotion health;
    public GameEvent gameEventToRaise;
    public IntValue playerHealth;

    public void Collect()
    {
        playerHealth.value += health.healthToHeal;
        gameEventToRaise.Fire();
    }
}
