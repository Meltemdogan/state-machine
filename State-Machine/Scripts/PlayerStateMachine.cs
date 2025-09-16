using UnityEngine;
public class PlayerStateMachine : StateMachine
{
    #region States
    private readonly WalkState _walkState;
    private readonly RunState _runState;
    private readonly IdleState _idleState;
    #endregion
    
    public PlayerStateMachine()
    {
        _walkState = new WalkState(this);
        _runState = new RunState(this);
        _idleState = new IdleState(this);
        
        ChangeState(_idleState);
    }
    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeState(_walkState);
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeState(_runState);
        }
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            ChangeState(_idleState);
        }
    }
}