//HintName: G.Models.AssistantMessageTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    public enum AssistantMessageTemplateFormat
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
    public static class AssistantMessageTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageTemplateFormat value)
        {
            return value switch
            {
                AssistantMessageTemplateFormat.FString => "f-string",
                AssistantMessageTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => AssistantMessageTemplateFormat.FString,
                "jinja2" => AssistantMessageTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}