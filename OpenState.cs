namespace Exercise5_Zavarin_Dor;

public class OpenState : IConnectionState
{
    public void Connect(NetworkConnection connection)
    {
        Console.WriteLine("Connection is already open.");
        Console.WriteLine();
    }

    public void ConnectionSuccessful(NetworkConnection connection)
    {
        Console.WriteLine("Connection is already successful and open.");
        Console.WriteLine();
    }

    public void ConnectionFailed(NetworkConnection connection)
    {
        Console.WriteLine("Connection failure detected while open.");
        connection.SetState(new ClosedState());
    }

    public void Disconnect(NetworkConnection connection)
    {
        Console.WriteLine("Disconnecting...");
        connection.SetState(new ClosedState());
    }
}