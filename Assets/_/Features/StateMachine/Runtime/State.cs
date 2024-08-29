namespace StateMachineRuntime
{
    public abstract class State 
    {
        #region Publics

        #endregion

        #region Unity API

        public State(ICanUseStateMachine character, StateMachine machine)
        {
            _character = character;
            _stateMachine = machine;
        }

        public abstract void Tick(float _deltaTime);

        public virtual void OnStateEnter() { }

        public virtual void OnStateExit() { }

        #endregion

        #region Main methods

        #endregion

        #region Utils
	
        #endregion

        #region Privates & Protected
	    
        protected ICanUseStateMachine _character;
        protected StateMachine _stateMachine;

        #endregion
    }

}
