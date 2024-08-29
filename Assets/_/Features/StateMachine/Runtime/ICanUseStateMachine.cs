using System;

namespace StateMachineRuntime
{
    public interface ICanUseStateMachine
    {
        public void DoIdle(float deltaTime);
        public String GetName();
        public bool HasFoundTarget();
    }
}