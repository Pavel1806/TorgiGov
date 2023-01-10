// See https://aka.ms/new-console-template for more information
using TorgiGov;

Console.WriteLine("Hello, World!");
//var torgiGovFetch = new TorgiGovFetch();
//await torgiGovFetch.FatchNotification();

Notification notification = new Notification();
await notification.ProcessingNotification();