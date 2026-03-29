//HintName: G.Models.AgentBlueprintWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentBlueprintWriteType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blueprint")]
        Blueprint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mask")]
        Mask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentBlueprintWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBlueprintWriteType value)
        {
            return value switch
            {
                AgentBlueprintWriteType.Blueprint => "blueprint",
                AgentBlueprintWriteType.Mask => "mask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBlueprintWriteType? ToEnum(string value)
        {
            return value switch
            {
                "blueprint" => AgentBlueprintWriteType.Blueprint,
                "mask" => AgentBlueprintWriteType.Mask,
                _ => null,
            };
        }
    }
}