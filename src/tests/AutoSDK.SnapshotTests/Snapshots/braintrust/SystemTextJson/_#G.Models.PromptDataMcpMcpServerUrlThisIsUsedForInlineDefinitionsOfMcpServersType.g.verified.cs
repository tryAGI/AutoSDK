//HintName: G.Models.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType value)
        {
            return value switch
            {
                PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? ToEnum(string value)
        {
            return value switch
            {
                "url" => PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType.Url,
                _ => null,
            };
        }
    }
}