//HintName: G.Models.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BulkUpdateMcpIntegrationCapabilitiesCapabilitieType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resource")]
        Resource,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateMcpIntegrationCapabilitiesCapabilitieType value)
        {
            return value switch
            {
                BulkUpdateMcpIntegrationCapabilitiesCapabilitieType.Prompt => "prompt",
                BulkUpdateMcpIntegrationCapabilitiesCapabilitieType.Resource => "resource",
                BulkUpdateMcpIntegrationCapabilitiesCapabilitieType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => BulkUpdateMcpIntegrationCapabilitiesCapabilitieType.Prompt,
                "resource" => BulkUpdateMcpIntegrationCapabilitiesCapabilitieType.Resource,
                "tool" => BulkUpdateMcpIntegrationCapabilitiesCapabilitieType.Tool,
                _ => null,
            };
        }
    }
}