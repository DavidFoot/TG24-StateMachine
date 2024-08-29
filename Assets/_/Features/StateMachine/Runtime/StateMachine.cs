using UnityEngine;

namespace StateMachineRuntime
{
    public class StateMachine : MonoBehaviour
    {
        #region Publics

        #endregion

        #region Unity API

        #endregion

        #region Main methods

        private void Start()
        {
            _chaseState = new ChaseState(_enemy, this);
            _idleState = new IdleState(_enemy, this);

            _currentState = _idleState;
            
        }

        private void Update()
        {
            _currentState.Tick(Time.deltaTime);
        }

        public void GoToChaseState() => _currentState = _chaseState;
        public void GoToIdleState() => _currentState = _idleState;


        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        [SerializeField] Enemy _enemy;

        private IdleState _idleState;
        private ChaseState _chaseState;
        private State _currentState;

        #endregion
    }

}
