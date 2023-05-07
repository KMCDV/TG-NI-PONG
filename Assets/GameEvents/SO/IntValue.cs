using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Data/Int Value", fileName = "New Int Value")]
public class IntValue : ScriptableObject, ISerializationCallbackReceiver
{
    public int value;
    public int InitialValue;

    public bool shouldResetOnPlay;

    public void OnAfterDeserialize()
    {
        if(shouldResetOnPlay)
            value = InitialValue;
    }

    public void OnBeforeSerialize()
    {
        
    }
}
