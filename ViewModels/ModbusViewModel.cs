using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommunicationProtocol.WPF.ViewModels
{
public class ModbusViewModel : INotifyPropertyChanged
{
private string _ip = "127.0.0.1";
public string Ip { get => _ip; set { _ip = value; OnPropertyChanged(); } }

private int _port = 502;
public int Port { get => _port; set { _port = value; OnPropertyChanged(); } }

private int _slaveId = 1;
public int SlaveId { get => _slaveId; set { _slaveId = value; OnPropertyChanged(); } }

private string _status = "Disconnected";
public string Status { get => _status; set { _status = value; OnPropertyChanged(); } }

public event PropertyChangedEventHandler? PropertyChanged;
protected void OnPropertyChanged([CallerMemberName] string? name = null)
=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
}
