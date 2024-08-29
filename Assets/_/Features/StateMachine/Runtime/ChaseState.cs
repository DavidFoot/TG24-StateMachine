using UnityEngine;

namespace StateMachineRuntime
{
    public class ChaseState : State
    {

        #region Publics

        #endregion

        #region Unity API

        #endregion

        #region Main methods

        public ChaseState(ICanUseStateMachine character) : base(character) { }

        public override State Tick(float _deltaTime)
        {
            _character.DoChase(_deltaTime);
            if (_character.TargetIsOutOfRange())
            {
                return new IdleState(_character);
            }
            return this;
        }
        public override void OnStateEnter()
        {
            _character.GetObject().GetComponent<MeshRenderer>().material.color = Color.red;
        }

        public override void OnStateExit()
        {
            _character.GetObject().GetComponent<MeshRenderer>().material.color = Color.blue;
        }

        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        #endregion
    }

}
