using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AnimationUI : MonoBehaviour
{
    public float timeAnimation;
    public AnimationCurve animCurve;
    public void Start()
    {
        LeanTween.scale(gameObject, Vector3.zero, 1f).setEase(animCurve);
        TweenAnimation();
    }

    public void Update()
    {
        
    }

    public void TweenAnimation()
    {
        LeanTween.scale(gameObject, Vector3.zero, timeAnimation).setEase(LeanTweenType.easeInBack);
    }
}
