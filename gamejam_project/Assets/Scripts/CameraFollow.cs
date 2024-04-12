using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform _playerTransform;

    [SerializeField] private float _flipRotationTime = 0.5f;
    private bool _isFacingRight;

    private void Awake()
    {
        _isFacingRight = PlayerMovement._isFacingRight;
    }
    private void Start()
    {
        //LeanTween.rotate(GameObject, DetermineRotation);
    }

    private float DetermineRotation()
    {
        _isFacingRight = !_isFacingRight;

        if(_isFacingRight)
        {
            return 180f;
        }
        else
        {
            return 0f;
        }
    }
}
