//HintName: G.Models.AgentBlueprintHistoryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentBlueprintHistoryType
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
    public static class AgentBlueprintHistoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBlueprintHistoryType value)
        {
            return value switch
            {
                AgentBlueprintHistoryType.Blueprint => "blueprint",
                AgentBlueprintHistoryType.Mask => "mask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBlueprintHistoryType? ToEnum(string value)
        {
            return value switch
            {
                "blueprint" => AgentBlueprintHistoryType.Blueprint,
                "mask" => AgentBlueprintHistoryType.Mask,
                _ => null,
            };
        }
    }
}