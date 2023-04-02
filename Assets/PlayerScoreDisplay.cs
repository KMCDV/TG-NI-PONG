using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScoreDisplay : MonoBehaviour
{
    [SerializeField] private int playerIndex;
    [SerializeField] private ScoreHolder scoreHolder;
    [SerializeField] TextMeshProUGUI textMesh;

    private void Awake()
    {
        scoreHolder.PlayerUpdated += UpdatePlayerScore;
        textMesh.text = "0";
    }

    private void UpdatePlayerScore(int playerIndex)
    {
        if(playerIndex != this.playerIndex)
            return;
        textMesh.text = scoreHolder.GetPlayerScore(playerIndex).ToString();
    }

    private void OnDestroy()
    {
        scoreHolder.PlayerUpdated -= UpdatePlayerScore;
    }

}
