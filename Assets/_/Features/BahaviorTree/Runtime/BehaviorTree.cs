using UnityEngine;

namespace BehaviorTree
{
    public class BehaviorTree : MonoBehaviour
    {
        #region Publics

        #endregion

        #region Unity API

        private void Awake()
        {
            _mainSequence = new Sequence();
            _mainSequence._children.Add(new GameObjectActivationLeaf(_gameObject, false));

            //_selector = new Selector();
            //_composite = new Sequence();
            //_composite._children.Add(new ReturnFailLeaf());
            //_composite._children.Add(new HelloWorldLeaf("David"));
            //_composite._children.Add(new WaitForSecondsLeaf(2));
            //_composite._children.Add(new HelloWorldLeaf("Jean"));
            //_selector._children.Add(new HelloWorldLeaf("Je suis un selector"));
            //_mainSequence._children.Add(_composite);
            //_mainSequence._children.Add(_selector);
        }

        private void Update()
        {
            _mainSequence.Process();
        }

        #endregion

        #region Main methods

        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        private Sequence _mainSequence;
        private Sequence _composite;
        private Selector _selector;
        [SerializeField] GameObject _gameObject;

        #endregion
    }

}
