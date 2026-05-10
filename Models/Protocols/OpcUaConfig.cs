namespace CommunicationProtocol.WPF.Models.Protocols
{
public class OpcUaConfig
{
public string EndpointUrl { get; set; } = "opc.tcp://127.0.0.1:4840";
public bool UseSecurity { get; set; } = false;
public int ReadIntervalMs { get; set; } = 1000;
}
}
