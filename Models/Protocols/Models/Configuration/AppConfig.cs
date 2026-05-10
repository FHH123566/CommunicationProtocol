using CommunicationProtocol.WPF.Models.Protocols;

namespace CommunicationProtocol.WPF.Models.Configuration
{
public class AppConfig
{
public ModbusTcpConfig ModbusTcpConfig { get; set; } = new();
public S7Config S7Config { get; set; } = new();
public OpcUaConfig OpcUaConfig { get; set; } = new();
public EtherNetIpConfig EtherNetIpConfig { get; set; } = new();
public string SelectedProtocol { get; set; } = "ModbusTcp";
}
}
