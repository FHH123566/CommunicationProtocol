namespace CommunicationProtocol.WPF.Models.Protocols
{
public class S7Config
{
public string IpAddress { get; set; } = "127.0.0.1";
public short Rack { get; set; } = 0;
public short Slot { get; set; } = 2;
public int ReadIntervalMs { get; set; } = 1000;
}
}
