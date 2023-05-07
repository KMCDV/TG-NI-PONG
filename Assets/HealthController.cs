using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public IntValue playerHealth;
    public void AddHealth(int hp) => playerHealth.value += hp;
}
