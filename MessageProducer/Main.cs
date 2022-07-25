using Microsoft.AspNetCore.SignalR.Client;

namespace MessageProducer;
public class Main
{
    HubConnection connection;
    public Main()
    {

        connection = new HubConnectionBuilder()
            .WithUrl("https://localhost:7252/TipHub")
            .WithAutomaticReconnect()
            .Build();

        connection.Closed += async (error) =>
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await connection.StartAsync();
        };
    }

    public async void Connect()
    {
        try
        {
            await connection.StartAsync();

        }
        catch (Exception ex)
        {
        }
    }

    public async void SendMessage(string message)
    {
        try
        {
            await connection.InvokeAsync("SendMessage", "Camilo", message);
        }
        catch (Exception ex)
        {
        }
    }
}
