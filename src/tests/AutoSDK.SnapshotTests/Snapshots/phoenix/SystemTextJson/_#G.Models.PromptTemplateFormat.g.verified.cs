//HintName: G.Models.PromptTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        FString,
        /// <summary>
        /// 
        /// </summary>
        Mustache,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTemplateFormat value)
        {
            return value switch
            {
                PromptTemplateFormat.FString => "F_STRING",
                PromptTemplateFormat.Mustache => "MUSTACHE",
                PromptTemplateFormat.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "F_STRING" => PromptTemplateFormat.FString,
                "MUSTACHE" => PromptTemplateFormat.Mustache,
                "NONE" => PromptTemplateFormat.None,
                _ => null,
            };
        }
    }
}