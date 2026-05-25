namespace Exercise5_Zavarin_Dor;

public class ClosedState : IConnectionState
{
    public void Connect(NetworkConnection connection)
    {
        Console.WriteLine("Trying to connect...");
        connection.SetState(new ConnectingState());
    }

    public void ConnectionSuccessful(NetworkConnection connection)
    {
        Console.WriteLine("Cannot succeed because the connection is closed.");
        Console.WriteLine();
    }

    public void ConnectionFailed(NetworkConnection connection)
    {
        Console.WriteLine("Connection is already closed.");
        Console.WriteLine();
    }

    public void Disconnect(NetworkConnection connection)
    {
        Console.WriteLine("Already disconnected.");
        Console.WriteLine();
    }
}