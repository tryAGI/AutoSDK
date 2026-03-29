//HintName: G.Models.McpServerCapabilityItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpServerCapabilityItemType
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
        ResourceTemplate,
        /// <summary>
        /// 
        /// </summary>
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