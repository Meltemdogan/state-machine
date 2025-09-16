using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerStateMachine stateMachine;
    
    private void Start()
    {
        stateMachine = new PlayerStateMachine();
    }
    
    private void Update()
    {
        stateMachine.HandleInput();
        stateMachine.Update();
    }
}