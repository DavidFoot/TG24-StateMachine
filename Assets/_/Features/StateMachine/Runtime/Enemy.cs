using System;
using UnityEngine;

namespace StateMachineRuntime
{
    public class Enemy : MonoBehaviour , ICanUseStateMachine
    {
        #region Publics

        #endregion

        #region Unity API

        #endregion

        #region Main methods

        public String GetName()
        {
            return gameObject.name;
        }

        public void DoIdle(float deltaTime)
        {
            Debug.Log("Do Nothing");
        }
        public void DoChase(float deltaTime)
        {
            transform.position = Vector3.MoveTowards(transform.position,_target.transform.position, _moveSpeed*deltaTime);
        }
        public bool TargetIsOutOfRange()
        {
            return !HasFoundTarget();
        }

        public bool HasFoundTarget() {
            return Vector3.SqrMagnitude(_target.position - transform.position) <= _detectionRange * _detectionRange;
        }

        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        [SerializeField] private float _detectionRange = 5;
        [SerializeField] private float _moveSpeed = 2;
        [SerializeField] private float _health = 100;
        [SerializeField] private float _stamina = 10;
        [SerializeField] private Transform _target;

        #endregion
    }
}