//HintName: G.Models.RegexOptionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the regex option. Options are:<br/>
    /// - `ignore-case`: Ignores the case of the text being matched. Add<br/>
    /// - `whole-word`: Matches whole words only.<br/>
    /// - `multi-line`: Matches across multiple lines.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RegexOptionType
    {
        /// <summary>
        /// Ignores the case of the text being matched. Add
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ignore-case")]
        IgnoreCase,
        /// <summary>
        /// Matches across multiple lines.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multi-line")]
        MultiLine,
        /// <summary>
        /// Matches whole words only.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whole-word")]
        WholeWord,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegexOptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegexOptionType value)
        {
            return value switch
            {
                RegexOptionType.IgnoreCase => "ignore-case",
                RegexOptionType.MultiLine => "multi-line",
                RegexOptionType.WholeWord => "whole-word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegexOptionType? ToEnum(string value)
        {
            return value switch
            {
                "ignore-case" => RegexOptionType.IgnoreCase,
                "multi-line" => RegexOptionType.MultiLine,
                "whole-word" => RegexOptionType.WholeWord,
                _ => null,
            };
        }
    }
}