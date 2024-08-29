using UnityEngine;

namespace BehaviorTree
{
    public class GameObjectActivationLeaf : Leaf
    {
        public GameObjectActivationLeaf(GameObject gameObject, bool enabled) {
            _gameObject = gameObject;
            _enabled = enabled; 
        }
        public override State Process()
        {
            if(_gameObject == null) return State.FAIL;
            _gameObject.SetActive(_enabled);
            return State.SUCCESS;

        }
        GameObject _gameObject;
        bool _enabled;
    }

}
