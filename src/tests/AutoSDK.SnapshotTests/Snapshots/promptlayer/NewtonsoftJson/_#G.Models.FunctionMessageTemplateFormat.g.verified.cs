//HintName: G.Models.FunctionMessageTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: f-string
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionMessageTemplateFormat
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
    public static class FunctionMessageTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionMessageTemplateFormat value)
        {
            return value switch
            {
                FunctionMessageTemplateFormat.FString => "f-string",
                FunctionMessageTemplateFormat.Jinja2 => "jinja2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionMessageTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => FunctionMessageTemplateFormat.FString,
                "jinja2" => FunctionMessageTemplateFormat.Jinja2,
                _ => null,
            };
        }
    }
}