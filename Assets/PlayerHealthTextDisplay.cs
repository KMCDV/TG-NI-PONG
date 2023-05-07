using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthTextDisplay : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public IntValue playerHealth;


    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePlayerText()
    {
        textMesh.text = $"HP: {playerHealth.value}";
    }
}
