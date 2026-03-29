//HintName: G.Models.UserMessageTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserMessageTemplateFormat
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
    public static class UserMessageTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageTemplateFormat value)
        {
            return value switch
            {
                UserMessageTemplateFormat.FString => "f-string",
                UserMessageTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => UserMessageTemplateFormat.FString,
                "jinja2" => UserMessageTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}