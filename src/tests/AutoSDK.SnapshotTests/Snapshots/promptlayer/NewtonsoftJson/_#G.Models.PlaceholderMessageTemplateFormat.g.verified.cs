//HintName: G.Models.PlaceholderMessageTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaceholderMessageTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="f-string")]
        FString,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jinja2")]
        Jinja2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaceholderMessageTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaceholderMessageTemplateFormat value)
        {
            return value switch
            {
                PlaceholderMessageTemplateFormat.FString => "f-string",
                PlaceholderMessageTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaceholderMessageTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => PlaceholderMessageTemplateFormat.FString,
                "jinja2" => PlaceholderMessageTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}