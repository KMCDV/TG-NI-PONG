using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleController : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public int health = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<HealthPotionController>())
        {
            health += collision.GetComponent<HealthPotionController>().health.healthToHeal;
            GetComponent<HealthController>().health = health;
            textMesh.text = health.ToString();
        }
    }
}
