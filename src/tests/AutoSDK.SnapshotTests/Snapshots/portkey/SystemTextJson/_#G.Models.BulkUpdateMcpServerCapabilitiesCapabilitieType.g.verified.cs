//HintName: G.Models.BulkUpdateMcpServerCapabilitiesCapabilitieType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkUpdateMcpServerCapabilitiesCapabilitieType
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Resource,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkUpdateMcpServerCapabilitiesCapabilitieTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateMcpServerCapabilitiesCapabilitieType value)
        {
            return value switch
            {
                BulkUpdateMcpServerCapabilitiesCapabilitieType.Prompt => "prompt",
                BulkUpdateMcpServerCapabilitiesCapabilitieType.Resource => "resource",
                BulkUpdateMcpServerCapabilitiesCapabilitieType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateMcpServerCapabilitiesCapabilitieType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => BulkUpdateMcpServerCapabilitiesCapabilitieType.Prompt,
                "resource" => BulkUpdateMcpServerCapabilitiesCapabilitieType.Resource,
                "tool" => BulkUpdateMcpServerCapabilitiesCapabilitieType.Tool,
                _ => null,
            };
        }
    }
}