//HintName: G.Models.PromptVersionDetailType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionDetailType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jinja2")]
        Jinja2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mustache")]
        Mustache,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionDetailType value)
        {
            return value switch
            {
                PromptVersionDetailType.Jinja2 => "jinja2",
                PromptVersionDetailType.Mustache => "mustache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionDetailType? ToEnum(string value)
        {
            return value switch
            {
                "jinja2" => PromptVersionDetailType.Jinja2,
                "mustache" => PromptVersionDetailType.Mustache,
                _ => null,
            };
        }
    }
}