namespace Exercise5_Zavarin_Dor;

public interface IConnectionState
{
    void Connect(NetworkConnection connection);
    void ConnectionSuccessful(NetworkConnection connection);
    void ConnectionFailed(NetworkConnection connection);
    void Disconnect(NetworkConnection connection);
}