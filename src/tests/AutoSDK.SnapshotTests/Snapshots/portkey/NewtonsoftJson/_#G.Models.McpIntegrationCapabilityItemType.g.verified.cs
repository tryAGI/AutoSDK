//HintName: G.Models.McpIntegrationCapabilityItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpIntegrationCapabilityItemType
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
    public static class McpIntegrationCapabilityItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationCapabilityItemType value)
        {
            return value switch
            {
                McpIntegrationCapabilityItemType.Prompt => "prompt",
                McpIntegrationCapabilityItemType.Resource => "resource",
                McpIntegrationCapabilityItemType.ResourceTemplate => "resource_template",
                McpIntegrationCapabilityItemType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationCapabilityItemType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => McpIntegrationCapabilityItemType.Prompt,
                "resource" => McpIntegrationCapabilityItemType.Resource,
                "resource_template" => McpIntegrationCapabilityItemType.ResourceTemplate,
                "tool" => McpIntegrationCapabilityItemType.Tool,
                _ => null,
            };
        }
    }
}