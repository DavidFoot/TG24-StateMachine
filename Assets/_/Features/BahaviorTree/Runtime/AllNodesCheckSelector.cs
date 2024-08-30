using UnityEngine;

namespace BehaviorTree
{
    public class AllNodesCheckSelector : Composite
    {
        public override State Process()
        {
            foreach (var _child in _children) { 
                var state = _child.Process();
                if (state == State.SUCCESS) {
                    return State.SUCCESS;
                }
                if (state == State.FAIL) {
                    continue;
                }
                return State.RUNNING;
            }
            return State.FAIL;
        }
    }

}
