using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class RotateAround : MonoBehaviour
    {
        public Transform target;
        public float speed;

        private void Start()
        {
            if (target != null) return;
            target = gameObject.transform;
            Debug.Log("Target não especificado, padronizando para o próprio objeto.");
        }

        private void Update()
        {
           transform.RotateAround(target.position,Vector3.up, speed * Time.deltaTime);
        }
    }
}