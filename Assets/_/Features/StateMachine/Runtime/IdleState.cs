using UnityEngine;

namespace StateMachineRuntime
{
    public class IdleState : State
    {
        #region Publics
	
        #endregion

        #region Unity API
	
        #endregion

        #region Main methods

        public IdleState(ICanUseStateMachine character, StateMachine machine) : base(character, machine) { }

        public override void Tick(float _deltaTime)
        {
            _character.DoIdle(Time.deltaTime);
            if (_character.HasFoundTarget())
            {
                Debug.Log("Found You!!");
                _stateMachine.GoToChaseState();
            }
        }


        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        #endregion
    }

}
