using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AterAnoth : MonoBehaviour
{
   
        public Transform target; 
        public float followSpeed = 5f; 
        public float stoppingDistance = 2f;
        private bool isFollowing = true;

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
            }

        }
}
