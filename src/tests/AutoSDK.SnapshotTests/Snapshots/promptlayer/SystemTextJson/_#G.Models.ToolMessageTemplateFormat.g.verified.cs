//HintName: G.Models.ToolMessageTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    public enum ToolMessageTemplateFormat
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
    public static class ToolMessageTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageTemplateFormat value)
        {
            return value switch
            {
                ToolMessageTemplateFormat.FString => "f-string",
                ToolMessageTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => ToolMessageTemplateFormat.FString,
                "jinja2" => ToolMessageTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}