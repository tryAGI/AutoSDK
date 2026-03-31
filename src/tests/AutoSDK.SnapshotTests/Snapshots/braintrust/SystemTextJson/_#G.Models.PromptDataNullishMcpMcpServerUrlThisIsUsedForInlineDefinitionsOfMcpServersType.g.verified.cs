//HintName: G.Models.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType value)
        {
            return value switch
            {
                PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? ToEnum(string value)
        {
            return value switch
            {
                "url" => PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType.Url,
                _ => null,
            };
        }
    }
}