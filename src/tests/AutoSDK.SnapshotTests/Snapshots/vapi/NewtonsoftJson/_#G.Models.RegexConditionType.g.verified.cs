//HintName: G.Models.RegexConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type discriminator for regex condition<br/>
    /// Example: regex
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RegexConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regex")]
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegexConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegexConditionType value)
        {
            return value switch
            {
                RegexConditionType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegexConditionType? ToEnum(string value)
        {
            return value switch
            {
                "regex" => RegexConditionType.Regex,
                _ => null,
            };
        }
    }
}