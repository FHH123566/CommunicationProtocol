using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunicationProtocol.WPF.Utils.Helpers;

namespace CommunicationProtocol.WPF.ViewModels
{
public class AlarmViewModel
{
public ObservableCollection<string> ActiveAlarms { get; } = new();
public ICommand AcknowledgeCommand { get; }

public AlarmViewModel()
{
ActiveAlarms.Add("High temperature alarm");
ActiveAlarms.Add("Connection lost");

AcknowledgeCommand = new RelayCommand<string>(alarm =>
{
if (alarm != null) ActiveAlarms.Remove(alarm);
});
}
}
}
