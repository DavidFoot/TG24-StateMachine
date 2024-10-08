using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorTree
{
    public class PatrolLeaf : Leaf
    {

        public PatrolLeaf(Transform transform, NavMeshAgent navMeshAgent, List<Transform> waypoints)
        {
            _transform = transform;
            _navMeshAgent = navMeshAgent;
            _waypoints = waypoints;
        }
        public override State Process()
        {
            if (_waypoints == null) return State.FAIL;
            if (_waypoints.Count == 0) return State.FAIL;

            if (_index == _waypoints.Count) { 
                _index = 0;
                return State.SUCCESS; 
            }
            var currentWaypoint = _waypoints[_index];
            _navMeshAgent.SetDestination(currentWaypoint.position);
            if (Vector3.SqrMagnitude(currentWaypoint.position - _transform.position) <= 3f) { 
                _index++;
            }
            return State.RUNNING;
        }

        private readonly Transform _transform;
        private readonly NavMeshAgent _navMeshAgent;
        private readonly List<Transform> _waypoints;
        private int _index;
    }


}
