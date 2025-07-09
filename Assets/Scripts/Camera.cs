using System;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform PlayerTransform;

    private void LateUpdate()
    {
        transform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y, -10f);
    }
}