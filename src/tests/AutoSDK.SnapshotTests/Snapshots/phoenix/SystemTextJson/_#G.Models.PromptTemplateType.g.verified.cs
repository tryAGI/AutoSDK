//HintName: G.Models.PromptTemplateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptTemplateType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Str,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTemplateType value)
        {
            return value switch
            {
                PromptTemplateType.Chat => "CHAT",
                PromptTemplateType.Str => "STR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTemplateType? ToEnum(string value)
        {
            return value switch
            {
                "CHAT" => PromptTemplateType.Chat,
                "STR" => PromptTemplateType.Str,
                _ => null,
            };
        }
    }
}