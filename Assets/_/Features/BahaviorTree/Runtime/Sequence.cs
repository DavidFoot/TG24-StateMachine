using UnityEngine;

namespace BehaviorTree
{
    public class Sequence : Composite
    {
        public override State Process()
        {
            var childstate = _children[_index].Process();
            if (childstate == State.SUCCESS) {
                _index++;
                if (_index >= _children.Count) {
                    _index = 0;
                    return State.SUCCESS;
                }
            }
            if (childstate == State.FAIL) {
                _index = 0;
                return State.FAIL;
            }
            return State.RUNNING;
        }
    }

}
