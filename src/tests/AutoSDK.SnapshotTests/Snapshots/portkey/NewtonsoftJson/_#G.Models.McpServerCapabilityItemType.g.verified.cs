//HintName: G.Models.McpServerCapabilityItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpServerCapabilityItemType
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
    public static class McpServerCapabilityItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerCapabilityItemType value)
        {
            return value switch
            {
                McpServerCapabilityItemType.Prompt => "prompt",
                McpServerCapabilityItemType.Resource => "resource",
                McpServerCapabilityItemType.ResourceTemplate => "resource_template",
                McpServerCapabilityItemType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerCapabilityItemType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => McpServerCapabilityItemType.Prompt,
                "resource" => McpServerCapabilityItemType.Resource,
                "resource_template" => McpServerCapabilityItemType.ResourceTemplate,
                "tool" => McpServerCapabilityItemType.Tool,
                _ => null,
            };
        }
    }
}