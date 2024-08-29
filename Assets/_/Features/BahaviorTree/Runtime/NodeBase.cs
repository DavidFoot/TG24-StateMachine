using UnityEngine;

public abstract class NodeBase
{
    public enum State
    {
        FAIL,
        SUCCESS,
        RUNNING
    };
    public abstract State Process();
}

