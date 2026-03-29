//HintName: G.Models.McpServerCapabilitiesListType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpServerCapabilitiesListType
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