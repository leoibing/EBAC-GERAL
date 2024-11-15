using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarAnimation : MonoBehaviour
{
	public float duration = 2f;
	public Ease ease = Ease.Linear;

    void Start()
    {
		transform.DOMoveX(6, duration).SetEase(ease);
    }
}
