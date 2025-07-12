using System;
using DG.Tweening;
using UnityEngine;

public class GhostPlatform : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    private void OnCollisionEnter2D(Collision2D other)
    {
        SpriteRenderer.DOFade(0f, 0.25f).SetLoops(12, LoopType.Yoyo).OnComplete(OnAnimationComplete);

    }

    private void OnAnimationComplete()
    {
        Destroy(gameObject);
    }
}
