using UnityEngine;

namespace BehaviorTree
{
    public class HelloWorldLeaf : Leaf
    {
        private string _text;
        public HelloWorldLeaf(string text)
        {
            _text = text;
        }
        public override State Process()
        {
            Debug.Log(_text);
            return State.SUCCESS;
        }
    }

}
