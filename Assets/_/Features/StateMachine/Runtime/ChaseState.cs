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

        public ChaseState(ICanUseStateMachine character, StateMachine machine) : base(character, machine) { }

        public override void Tick(float _deltaTime)
        {
            _character.DoChase(_deltaTime);
            if (_character.TargetIsOutOfRange())
            {
                _stateMachine.GoToIdleState();
            }
        }


        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        #endregion
    }

}
