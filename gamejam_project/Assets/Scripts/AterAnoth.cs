using HeneGames.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class AterAnoth : MonoBehaviour
{
   
    public Transform target; 
    public float followSpeed = 5f; 
    public float stoppingDistance = 2f;
    private bool isFollowing = true;
    public Animator animator;
    Vector2 vector2;

    private void Start()
    {
        vector2 = gameObject.transform.position;
    }
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            isFollowing = true;
        }
        else
        {
            isFollowing = false;
        }

        if (isFollowing)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, followSpeed * Time.deltaTime);
            OnBeforeTransformChanged();

        }

        else
        {
            animator.SetFloat("speed", 0);
        }

    }

    private void OnBeforeTransformChanged()
    {
        if (gameObject.transform.hasChanged && isFollowing)
        {
           
            animator.SetFloat("speed", vector2.sqrMagnitude);
            gameObject.transform.hasChanged = false;

            // поворачивание игрока 
            //if (vector2 > 0.01f)
            //{
            //transform.localScale = Vector3.one;
            //}
            //if (vector2 < -0.01f)
            //{
            //   transform.localScale = new Vector3(-1, 1, 1);
            //}
        }
    }

}
