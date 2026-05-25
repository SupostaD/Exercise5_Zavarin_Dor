namespace Exercise5_Zavarin_Dor;

public class NetworkConnection
{
    private IConnectionState _currentState;

    public NetworkConnection()
    {
        _currentState = new ClosedState();
        Console.WriteLine("System started in CLOSED STATE.");
    }

    public void SetState(IConnectionState newState)
    {
        _currentState = newState;
        Console.WriteLine($"State changed to: {_currentState.GetType().Name}");
        Console.WriteLine();
    }

    public void Connect()
    {
        _currentState.Connect(this);
    }

    public void ConnectionSuccessful()
    {
        _currentState.ConnectionSuccessful(this);
    }

    public void ConnectionFailed()
    {
        _currentState.ConnectionFailed(this);
    }

    public void Disconnect()
    {
        _currentState.Disconnect(this);
    }
}