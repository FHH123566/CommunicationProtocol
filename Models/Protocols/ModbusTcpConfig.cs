namespace CommunicationProtocol.WPF.Models.Protocols
{
public class ModbusTcpConfig
{
public string IpAddress { get; set; } = "127.0.0.1";
public int Port { get; set; } = 502;
public byte SlaveId { get; set; } = 1;
public int ReadIntervalMs { get; set; } = 1000;
}
}
