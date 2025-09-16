public abstract class StateMachine
{
    //Nested class
    public abstract class State
    {
        protected StateMachine machine;
        
        protected State(StateMachine machine)
        {
            this.machine = machine;
        }
        
        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
    }
    
    protected State currentState;
    
    public void ChangeState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }
    
    public void Update()
    {
        currentState?.Update();
    }
}