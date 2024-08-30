using System;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace StateMachineRuntime
{
    public class Enemy : MonoBehaviour , ICanUseStateMachine
    {
        #region Publics

        #endregion

        #region Unity API
        private void Start()
        {
            
        }


        private void Update()
        {
            if (Physics.Linecast(transform.position, _target.position,_layermask))
            {
                //Debug.Log("blocked");
            }
        }

        #endregion

        #region Main methods

        public String GetName()
        {
            return gameObject.name;
        }
        public GameObject GetObject()
        {
            return gameObject;
        }
        public void DoIdle(float deltaTime)
        {
            //Debug.Log("Do Nothing");
        }
        public void DoChase(float deltaTime)
        {
            transform.position = Vector3.MoveTowards(transform.position,_target.transform.position, _moveSpeed*deltaTime);
        }
        public bool TargetIsOutOfRange()
        {
            return  Vector3.SqrMagnitude(_target.position - transform.position) > _outOfRangeDistancee * _outOfRangeDistancee;
        }

        public bool HasFoundTarget() {
            return Vector3.SqrMagnitude(_target.position - transform.position) <= _detectionRange * _detectionRange;
        }

        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        [SerializeField] private float _detectionRange = 5;
        [SerializeField] private float _outOfRangeDistancee = 15;
        [SerializeField] private float _moveSpeed = 2;
        [SerializeField] private float _health = 100;
        [SerializeField] private float _stamina = 10;
        [SerializeField] private Transform _target;
        [SerializeField] private LayerMask _layermask;

        #endregion
    }
}