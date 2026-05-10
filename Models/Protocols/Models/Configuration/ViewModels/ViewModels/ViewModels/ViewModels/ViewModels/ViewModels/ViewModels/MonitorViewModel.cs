using System.Collections.ObjectModel;
using System;
using System.Windows.Threading;

namespace CommunicationProtocol.WPF.ViewModels
{
public class MonitorViewModel
{
public ObservableCollection<string> RealTimeData { get; } = new();

public MonitorViewModel()
{
var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
timer.Tick += (s, e) =>
{
RealTimeData.Add($"{DateTime.Now:T} - Value: {Random.Shared.Next(0, 100)}");
if (RealTimeData.Count > 50) RealTimeData.RemoveAt(0);
};
timer.Start();
}
}
}
