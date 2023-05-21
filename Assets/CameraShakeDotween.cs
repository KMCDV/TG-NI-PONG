using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CameraShakeDotween : MonoBehaviour
{
    public float intensity = -1;
    public VolumeProfile profile;

    private void Start()
    {
        DOVirtual.Float(-1, 1, 1f, UpdateIntensity).SetLoops(-1, LoopType.Yoyo);
    }

    private void UpdateIntensity(float newValue)
    {
        intensity = newValue;
        if(profile.TryGet(out LensDistortion lensDistortion)) 
        {
            lensDistortion.intensity.Override(intensity);
        }
    }

    public void ShakeCamera()
    {
        transform.DOShakePosition(.5f, .5f, 5);
    }
}
