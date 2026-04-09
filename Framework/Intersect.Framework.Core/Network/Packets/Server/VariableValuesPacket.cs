using MessagePack;

namespace Intersect.Network.Packets.Server;

[MessagePackObject(true)]
public partial class VariableValuesPacket : IntersectPacket
{
    public VariableValuesPacket()
    {
    }

    public VariableValuesPacket(Dictionary<string, string> values)
    {
        Values = values;
    }

    [Key(0)]
    public Dictionary<string, string> Values { get; set; } = new();
}