using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int health;
    public void AddHealth(int hp) => health += hp;
}
