using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AnimationUI : MonoBehaviour
{
    public float timeAnimation;
    public AnimationCurve animCurve;
    private RectTransform Button;

    private TargetQR targetQR;
    public void Start()
    {
        targetQR = FindObjectOfType<TargetQR>();
        Button = gameObject.GetComponent<RectTransform>();
        targetQR.onTargetOnEnable += TweenAnimation;
    }

    public void Update()
    {
    }

    public void TweenAnimation()
    {
        Button.localScale = Vector3.zero;
        LeanTween.scale(gameObject, Vector3.one, timeAnimation).setEase(animCurve);
    }
}
