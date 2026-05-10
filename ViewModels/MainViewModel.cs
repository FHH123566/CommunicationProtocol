namespace CommunicationProtocol.WPF.ViewModels
{
public class MainViewModel
{
public ProtocolViewModel ProtocolViewModel { get; }
public MonitorViewModel MonitorViewModel { get; }
public AlarmViewModel AlarmViewModel { get; }

public MainViewModel()
{
ProtocolViewModel = new ProtocolViewModel();
MonitorViewModel = new MonitorViewModel();
AlarmViewModel = new AlarmViewModel();
}
}
}
