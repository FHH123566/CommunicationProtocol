using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommunicationProtocol.WPF.ViewModels
{
public class S7ViewModel : INotifyPropertyChanged
{
private string _ip = "127.0.0.1";
public string Ip { get => _ip; set { _ip = value; OnPropertyChanged(); } }

private short _rack;
public short Rack { get => _rack; set { _rack = value; OnPropertyChanged(); } }

private short _slot = 2;
public short Slot { get => _slot; set { _slot = value; OnPropertyChanged(); } }

private string _status = "Disconnected";
public string Status { get => _status; set { _status = value; OnPropertyChanged(); } }

public event PropertyChangedEventHandler? PropertyChanged;
protected void OnPropertyChanged([CallerMemberName] string? name = null)
=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
}
