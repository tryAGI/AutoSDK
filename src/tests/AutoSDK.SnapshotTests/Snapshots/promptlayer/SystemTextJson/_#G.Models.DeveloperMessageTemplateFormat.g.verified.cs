//HintName: G.Models.DeveloperMessageTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    public enum DeveloperMessageTemplateFormat
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
    public static class DeveloperMessageTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeveloperMessageTemplateFormat value)
        {
            return value switch
            {
                DeveloperMessageTemplateFormat.FString => "f-string",
                DeveloperMessageTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeveloperMessageTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => DeveloperMessageTemplateFormat.FString,
                "jinja2" => DeveloperMessageTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}