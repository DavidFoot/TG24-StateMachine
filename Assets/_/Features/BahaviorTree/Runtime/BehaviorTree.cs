using UnityEngine;
using UnityEngine.AI;

namespace BehaviorTree
{
    public class BehaviorTree : MonoBehaviour
    {
        #region Publics

        #endregion

        #region Unity API

        private void Start()
        {
            //_mainNode = new AllNodesCheckSelector();
            _mainNode = new AllNodesCheckSelector();
            _mainNode._children.Add(new GoToWCIfFree(transform,GetComponent<NavMeshAgent>(),_wc, _wcSpeed));
            _mainNode._children.Add(new WaitForSecondsLeaf(4));
            _mainNode._children.Add(new PatrolLeaf(transform,GetComponent<NavMeshAgent>(), _patrolPoints.GetWaypoints()));

            //_mainNode._children.Add(new WaitForSecondsLeaf(2));
            //_mainNode._children.Add(new HelloWorldLeaf("Bonjour les amis"));
            ///_compositeNode_01 = new Sequence();
            //_compositeNode_01._children.Add(new HelloWorldLeaf("Bonjour les amis"));

            //_compositeNode_01._children.Add(new WaitForSecondsLeaf(2));
            //_compositeNode_01._children.Add(new GameObjectActivationLeaf(_gameObject, true));
            //
            //_compositeNode_01._children.Add(new GameObjectActivationLeaf(_gameObject, false));
            //_compositeNode_01._children.Add(new HelloWorldLeaf("Ceci est une sequence"));


            //_selector = new Selector();
            //_selector._children.Add(new HelloWorldLeaf("This is a Selector"));

            //_mainNode._children.Add(_compositeNode_01);
            //_mainNode._children.Add(_selector);
        }

        private void Update()
        {
           _mainNode.Process();
        }

        #endregion

        #region Main methods

        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        private Composite _mainNode;
        private Composite _compositeNode_01;     
        private Selector _selector;


        [SerializeField] GameObject _gameObject;
        [SerializeField] PatrolManager _patrolPoints;
        [SerializeField] WCBehavior _wc;
        [SerializeField] float _wcSpeed;

        #endregion
    }

}
