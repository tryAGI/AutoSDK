//HintName: G.Models.McpIntegrationCapabilitiesListType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpIntegrationCapabilitiesListType
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
        [global::System.Runtime.Serialization.EnumMember(Value="resource_template")]
        ResourceTemplate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpIntegrationCapabilitiesListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationCapabilitiesListType value)
        {
            return value switch
            {
                McpIntegrationCapabilitiesListType.Prompt => "prompt",
                McpIntegrationCapabilitiesListType.Resource => "resource",
                McpIntegrationCapabilitiesListType.ResourceTemplate => "resource_template",
                McpIntegrationCapabilitiesListType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationCapabilitiesListType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => McpIntegrationCapabilitiesListType.Prompt,
                "resource" => McpIntegrationCapabilitiesListType.Resource,
                "resource_template" => McpIntegrationCapabilitiesListType.ResourceTemplate,
                "tool" => McpIntegrationCapabilitiesListType.Tool,
                _ => null,
            };
        }
    }
}