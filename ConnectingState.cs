namespace Exercise5_Zavarin_Dor;

public class ConnectingState : IConnectionState
{
    public void Connect(NetworkConnection connection)
    {
        Console.WriteLine("Already trying to connect...");
        Console.WriteLine();
    }

    public void ConnectionSuccessful(NetworkConnection connection)
    {
        Console.WriteLine("Connection successful!");
        connection.SetState(new OpenState());
    }

    public void ConnectionFailed(NetworkConnection connection)
    {
        Console.WriteLine("Connection failed.");
        connection.SetState(new ClosedState());
    }

    public void Disconnect(NetworkConnection connection)
    {
        Console.WriteLine("Connection attempt cancelled.");
        connection.SetState(new ClosedState());
    }
}