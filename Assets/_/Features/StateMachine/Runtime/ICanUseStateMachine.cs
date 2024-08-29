using System;

namespace StateMachineRuntime
{
    public interface ICanUseStateMachine
    {
        public void DoChase(float deltaTime);
        public void DoIdle(float deltaTime);
        public String GetName();
        public bool HasFoundTarget();
        public bool TargetIsOutOfRange();
    }
}