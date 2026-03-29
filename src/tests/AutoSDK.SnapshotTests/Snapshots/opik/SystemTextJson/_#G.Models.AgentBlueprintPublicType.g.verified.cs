//HintName: G.Models.AgentBlueprintPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentBlueprintPublicType
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
    public static class AgentBlueprintPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBlueprintPublicType value)
        {
            return value switch
            {
                AgentBlueprintPublicType.Blueprint => "blueprint",
                AgentBlueprintPublicType.Mask => "mask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBlueprintPublicType? ToEnum(string value)
        {
            return value switch
            {
                "blueprint" => AgentBlueprintPublicType.Blueprint,
                "mask" => AgentBlueprintPublicType.Mask,
                _ => null,
            };
        }
    }
}