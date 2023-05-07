using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Data/HealthPotion", fileName = "New Health Potion")]
public class HealthPotion : ScriptableObject
{
    public int healthToHeal;
}
