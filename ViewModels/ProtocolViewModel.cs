using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunicationProtocol.WPF.Utils.Helpers;

namespace CommunicationProtocol.WPF.ViewModels
{
public class ProtocolViewModel : INotifyPropertyChanged
{
public ObservableCollection<string> ProtocolNames { get; } = new() { "ModbusTcp", "S7", "OpcUa", "EtherNetIp" };

private string _selectedProtocol = "ModbusTcp";
public string SelectedProtocol
{
get => _selectedProtocol;
set { _selectedProtocol = value; OnPropertyChanged(); SwitchView(value); }
}

private object _currentViewModel;
public object CurrentViewModel
{
get => _currentViewModel;
set { _currentViewModel = value; OnPropertyChanged(); }
}

public ModbusViewModel ModbusVM { get; } = new();
public S7ViewModel S7VM { get; } = new();
public OpcUaViewModel OpcUaVM { get; } = new();
public EtherNetIpViewModel EtherNetIpVM { get; } = new();

public ICommand ConnectCommand { get; }
public ICommand DisconnectCommand { get; }

public ProtocolViewModel()
{
CurrentViewModel = ModbusVM;
ConnectCommand = new RelayCommand(Connect);
DisconnectCommand = new RelayCommand(Disconnect);
}

private void SwitchView(string protocol)
{
CurrentViewModel = protocol switch
{
"ModbusTcp" => ModbusVM,
"S7" => S7VM,
"OpcUa" => OpcUaVM,
"EtherNetIp" => EtherNetIpVM,
_ => ModbusVM
};
}

private void Connect()
{
UpdateStatus("Connected");
}

private void Disconnect()
{
UpdateStatus("Disconnected");
}

private void UpdateStatus(string status)
{
if (CurrentViewModel is ModbusViewModel m) m.Status = status;
else if (CurrentViewModel is S7ViewModel s) s.Status = status;
else if (CurrentViewModel is OpcUaViewModel o) o.Status = status;
else if (CurrentViewModel is EtherNetIpViewModel e) e.Status = status;
}

public event PropertyChangedEventHandler? PropertyChanged;
protected void OnPropertyChanged([CallerMemberName] string? name = null)
=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
}
