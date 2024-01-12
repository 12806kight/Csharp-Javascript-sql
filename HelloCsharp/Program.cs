using System.Net.NetworkInformation;
using System.Text;
using HelloCsharp;

PingService pingService = new PingService();

var response = pingService.SendPing();

Console.WriteLine(response);