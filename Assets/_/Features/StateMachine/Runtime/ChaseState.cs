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
            //Debug.Log(_character.GetName());
        }


        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        #endregion
    }

}
