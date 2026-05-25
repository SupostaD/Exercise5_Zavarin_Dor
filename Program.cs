namespace Exercise5_Zavarin_Dor;

class Program
{
    static void Main(string[] args)
    {
        NetworkConnection connection = new NetworkConnection();

        Console.WriteLine("FLOW 1: Successful Connection");
        connection.Connect();                // Closed -> Connecting
        connection.ConnectionSuccessful();   // Connecting -> Open

        Console.WriteLine("FLOW 2: Return To Closed State");
        connection.Disconnect();             // Open -> Closed

        Console.WriteLine("FLOW 3: Failed Connection");
        connection.Connect();                // Closed -> Connecting
        connection.ConnectionFailed();       // Connecting -> Closed

        Console.WriteLine("FLOW 4: Invalid Actions Demonstration");
        connection.Disconnect();             // Already closed
        connection.ConnectionSuccessful();   // Cannot succeed while closed

        Console.WriteLine("Demo finished.");
        Console.ReadLine();
    }
}