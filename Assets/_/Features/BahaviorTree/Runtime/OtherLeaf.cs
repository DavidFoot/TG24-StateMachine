using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorTree
{
    public class OtherLeaf : MonoBehaviour
    {

    }
    public class WaitForSecondsLeaf : Leaf
    {
        public WaitForSecondsLeaf(float duration)
        {
            _duration = duration;

        }
        public override State Process()
        {
            _timer += Time.deltaTime;
            if (_timer >= _duration)
            {
                _timer = 0;
                Debug.Log($"WaitForSecondsLeaf : Fail");
                return State.FAIL;
            }
            Debug.Log($"WaitForSecondsLeaf : Running");
            return State.RUNNING;
        }

        private float _timer;
        private float _duration;
    }

    public class ReturnFailLeaf : Leaf
    {
        public override State Process()
        {
            Debug.Log("Return Fail");
            return State.FAIL;
        }
    }
    public class CheckIfGameObjectIsActive : Leaf
    {
        public CheckIfGameObjectIsActive(GameObject go) {
            _gameObject = go;
        }
        public override State Process()
        {
            if (_gameObject = null) { return State.FAIL; }
            if (_gameObject.activeSelf) { return State.SUCCESS; }
            return State.FAIL;

        }
        private GameObject _gameObject;

    }
    public class GoToWCIfFree : Leaf
    {
        public GoToWCIfFree(Transform transform, NavMeshAgent navMeshAgent, WCBehavior wc, float wcSpeed)
        {
            _wcBehavior = wc; 
            _transform = transform; 
            _navMeshAgent = navMeshAgent;
            _wcSpeed = wcSpeed;
        }
        public override State Process() 
        {
            
            if (_wcBehavior.IsWCFree())
            {
                _navMeshAgent.SetDestination(_wcBehavior.transform.position);
                _navMeshAgent.speed = _wcSpeed;
                if (Vector3.SqrMagnitude(_wcBehavior.transform.position - _transform.position) <= 1f)
                {
                    Debug.Log($"GoToWCIfFree : Success");
                    return State.SUCCESS;
                }
            }
            else
            {
                _navMeshAgent.speed = _wcSpeed/2;
                Debug.Log($"GoToWCIfFree : Fail");
                return State.FAIL;
            }
            Debug.Log($"GoToWCIfFree : Running");
            return State.RUNNING;
        }
        WCBehavior _wcBehavior;
        Transform _transform;
        NavMeshAgent _navMeshAgent;
        float _originalSpeed;
        float _wcSpeed;
    }
}
