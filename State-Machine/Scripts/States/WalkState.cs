using UnityEngine;

public class WalkState : StateMachine.State
{
    public WalkState(StateMachine machine) : base(machine) { }
    
    public override void Enter() => Debug.Log("Enter Walk");
    public override void Update() => Debug.Log("Walking...");
    public override void Exit() => Debug.Log("Exit Walk");
}