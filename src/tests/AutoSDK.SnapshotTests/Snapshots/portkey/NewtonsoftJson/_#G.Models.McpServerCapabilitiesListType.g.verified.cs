//HintName: G.Models.McpServerCapabilitiesListType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpServerCapabilitiesListType
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
    public static class McpServerCapabilitiesListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerCapabilitiesListType value)
        {
            return value switch
            {
                McpServerCapabilitiesListType.Prompt => "prompt",
                McpServerCapabilitiesListType.Resource => "resource",
                McpServerCapabilitiesListType.ResourceTemplate => "resource_template",
                McpServerCapabilitiesListType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerCapabilitiesListType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => McpServerCapabilitiesListType.Prompt,
                "resource" => McpServerCapabilitiesListType.Resource,
                "resource_template" => McpServerCapabilitiesListType.ResourceTemplate,
                "tool" => McpServerCapabilitiesListType.Tool,
                _ => null,
            };
        }
    }
}