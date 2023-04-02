using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "Score Holder", menuName = "Score Holder", order = 0)]
public class ScoreHolder : ScriptableObject
{
    private List<int> ScoreList = new List<int>();
    public Action<int> PlayerUpdated;

    public int GetPlayerScore(int playerIndex) => ScoreList[playerIndex];

    public void SetPlayerScore(int playerIndex, int scoreToSet)
    {
        ScoreList[playerIndex] = scoreToSet;
        PlayerUpdated?.Invoke(playerIndex);
    }

    private void OnEnable()
    {
        Reset();
    }

    public void Reset()
    {
        ScoreList = new List<int> { 0, 0 };
        PlayerUpdated?.Invoke(0);
        PlayerUpdated?.Invoke(1);
    }
}
