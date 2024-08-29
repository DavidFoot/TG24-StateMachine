using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public abstract class Composite : NodeBase
    {
        public List<NodeBase> _children = new();
        protected int _index;
        public override abstract State Process();
    }

}
