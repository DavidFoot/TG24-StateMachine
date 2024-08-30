using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public class WCBehavior : MonoBehaviour
    {
        #region Publics

        #endregion

        #region Unity API

        private void Start()
        {
            _renderer = GetComponent<MeshRenderer>();
            _renderer.material.color = _ready;
            _isOqp = false;

        }

        private void Update()
        {
            if (Vector3.SqrMagnitude(transform.position - _player.transform.position) <= 2f)
            {
                _renderer.material.color = _oqp;
                _isOqp = true;
            }
            else
            {
                ManageWCTimer();
            }
            
        }

        #endregion

        #region Main methods
        private void ManageWCTimer()
        {
            if (_isOqp == false)
            {
                timer1 -= Time.deltaTime;
                if (timer1 <= 0)
                {
                    _isOqp = true;
                    timer1 = _timerStayFree;
                    _renderer.material.color = _oqp;
                }
            }
            else
            {
                timer2 -= Time.deltaTime;
                if (timer2 <= 0)
                {
                    _isOqp = false;
                    timer2 = _timeOqp;
                    _renderer.material.color = _ready;
                }
            }
        }

        public bool IsWCFree()
        {
            return !_isOqp;
        }

        #endregion

        #region Utils

        #endregion

        #region Privates & Protected

        [SerializeField] Color _oqp;	    
        [SerializeField] Color _ready;
        bool _isOqp = true;
        MeshRenderer _renderer;
        [SerializeField] GameObject _player;
        [SerializeField] float _timeOqp;
        [SerializeField] float _timerStayFree;
        float timer1;
        float timer2;
        
        #endregion
    }

}
