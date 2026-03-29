//HintName: G.Models.AgentBlueprintWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentBlueprintWriteType
    {
        /// <summary>
        /// 
        /// </summary>
        Blueprint,
        /// <summary>
        /// 
        /// </summary>
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