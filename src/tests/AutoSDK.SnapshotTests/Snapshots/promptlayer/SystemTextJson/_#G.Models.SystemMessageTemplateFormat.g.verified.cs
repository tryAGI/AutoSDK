//HintName: G.Models.SystemMessageTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    public enum SystemMessageTemplateFormat
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
    public static class SystemMessageTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageTemplateFormat value)
        {
            return value switch
            {
                SystemMessageTemplateFormat.FString => "f-string",
                SystemMessageTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => SystemMessageTemplateFormat.FString,
                "jinja2" => SystemMessageTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}