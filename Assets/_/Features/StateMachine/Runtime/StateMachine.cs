using System.Resources;
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
            _currentState = new IdleState(_enemy);
            _currentState.OnStateEnter();
        }

        private void Update()
        {
            var possibleNextState = _currentState.Tick(Time.deltaTime);
            if(possibleNextState != _currentState)
            {
                _currentState.OnStateExit();
                _currentState = possibleNextState;
                _currentState.OnStateEnter();
            }
        }

        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        [SerializeField] Enemy _enemy;
        State _currentState;

        #endregion
    }

}
