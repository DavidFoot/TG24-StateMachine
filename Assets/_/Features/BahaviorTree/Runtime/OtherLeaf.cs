using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public class OtherLeaf : MonoBehaviour
    {

    }
    public class WaitForSecondsLeaf : Leaf
    {
        public WaitForSecondsLeaf(float duration)
        {
            _duration = duration;

        }
        public override State Process()
        {
            _timer += Time.deltaTime;
            if (_timer >= _duration)
            {
                _timer = 0;
                return State.SUCCESS;
            }
            return State.RUNNING;
        }

        private float _timer;
        private float _duration;
    }

    public class ReturnFailLeaf : Leaf
    {
        public override State Process()
        {
            Debug.Log("Return Fail");
            return State.FAIL;
        }
    }

}
