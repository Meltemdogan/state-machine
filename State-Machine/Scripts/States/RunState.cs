using UnityEngine;


public class RunState : StateMachine.State
{
    public RunState(StateMachine machine) : base(machine) { }
    
    public override void Enter() => Debug.Log("Enter Run");
    public override void Update() => Debug.Log("Running...");
    public override void Exit() => Debug.Log("Exit Run");
}