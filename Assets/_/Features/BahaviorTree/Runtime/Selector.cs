using BehaviorTree;

namespace BehaviorTree
{
    public class Selector : Composite
    {
        public override State Process()
        {
            var childstate = _children[_index].Process();
            if (childstate == State.SUCCESS)
            {
                _index = 0;
                return State.SUCCESS;
            }
            if (childstate == State.FAIL)
            {
                _index++;
                if(_index >= _children.Count)
                {
                    _index = 0;
                    return State.FAIL;
                }
            }
            return State.RUNNING;
        }
    }

}
