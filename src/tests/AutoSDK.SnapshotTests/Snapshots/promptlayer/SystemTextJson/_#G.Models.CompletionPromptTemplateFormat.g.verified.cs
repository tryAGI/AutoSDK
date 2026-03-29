//HintName: G.Models.CompletionPromptTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    public enum CompletionPromptTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        FString,
        /// <summary>
        /// 
        /// </summary>
        Jinja2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionPromptTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionPromptTemplateFormat value)
        {
            return value switch
            {
                CompletionPromptTemplateFormat.FString => "f-string",
                CompletionPromptTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionPromptTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => CompletionPromptTemplateFormat.FString,
                "jinja2" => CompletionPromptTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}