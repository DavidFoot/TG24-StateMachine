namespace StateMachineRuntime
{
    public abstract class State 
    {
        #region Publics

        #endregion

        #region Unity API

        public State(ICanUseStateMachine character)
        {
            _character = character;
        }

        public abstract State Tick(float _deltaTime);

        public virtual void OnStateEnter() { }

        public virtual void OnStateExit() { }

        #endregion

        #region Main methods

        #endregion

        #region Utils
	
        #endregion

        #region Privates & Protected
	    
        protected ICanUseStateMachine _character;

        #endregion
    }

}
