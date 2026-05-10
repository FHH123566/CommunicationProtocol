using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommunicationProtocol.WPF.ViewModels
{
public class OpcUaViewModel : INotifyPropertyChanged
{
private string _endpointUrl = "opc.tcp://127.0.0.1:4840";
public string EndpointUrl { get => _endpointUrl; set { _endpointUrl = value; OnPropertyChanged(); } }

private bool _useSecurity;
public bool UseSecurity { get => _useSecurity; set { _useSecurity = value; OnPropertyChanged(); } }

private string _status = "Disconnected";
public string Status { get => _status; set { _status = value; OnPropertyChanged(); } }

public event PropertyChangedEventHandler? PropertyChanged;
protected void OnPropertyChanged([CallerMemberName] string? name = null)
=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
}
