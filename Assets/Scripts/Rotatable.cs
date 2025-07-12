using DG.Tweening;
using UnityEngine;

public class Rotatable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 360), 1.5f,RotateMode.FastBeyond360)
            .SetLoops(-1)
            .SetEase(Ease.InElastic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
