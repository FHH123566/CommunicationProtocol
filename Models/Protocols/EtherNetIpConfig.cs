namespace CommunicationProtocol.WPF.Models.Protocols
{
public class EtherNetIpConfig
{
public string IpAddress { get; set; } = "127.0.0.1";
public int Port { get; set; } = 44818;
public int ReadIntervalMs { get; set; } = 1000;
}
}
