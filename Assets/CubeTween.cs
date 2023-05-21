using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CubeTween : MonoBehaviour
{
    public AnimationCurve curve;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        //transform.DORotate(new Vector3(0, 0, 360), 2f, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Yoyo);
        //transform.DOScale(1.6f, 2f).SetLoops(2, LoopType.Yoyo);
        //transform.DOMoveY(2, 1f).SetLoops(-1, LoopType.Yoyo).SetRelative(true).SetEase(curve);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        Camera.main.GetComponent<CameraShakeDotween>().ShakeCamera();
        spriteRenderer.DOColor(Color.red, .05f).SetLoops(10, LoopType.Restart).OnComplete(ResetColorToWhite);
    }

    private void ResetColorToWhite()
    {
        spriteRenderer.color = Color.white;
    }
}
