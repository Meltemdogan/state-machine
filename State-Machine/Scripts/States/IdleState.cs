using UnityEngine;


public class IdleState : StateMachine.State
{
    public IdleState(StateMachine machine) : base(machine) { }
    
    public override void Enter() => Debug.Log("Enter Idle");
    public override void Update() => Debug.Log("Idle...");
    public override void Exit() => Debug.Log("Exit Idle");
}