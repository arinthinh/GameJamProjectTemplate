using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SpiningCircle : MonoBehaviour
{
    private RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        _rectTransform.transform.rotation = Quaternion.identity;
        _rectTransform
            .DORotate(Vector3.forward * 180, 2f)
            .SetLoops(-1, LoopType.Incremental)
            .SetEase(Ease.Linear);
    }

    private void OnDisable()
    {
        _rectTransform.DOKill();
    }
}
