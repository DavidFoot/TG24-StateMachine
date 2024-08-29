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

        public IdleState(ICanUseStateMachine character) : base(character) { }

        public override State Tick(float _deltaTime)
        {
            _character.DoIdle(_deltaTime);
            if (_character.HasFoundTarget())
            {
                return new ChaseState(_character);
            }
            return this;
        }

        public override void OnStateEnter()
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
