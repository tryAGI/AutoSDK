//HintName: G.Models.SkippedEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `only` - only<br/>
    /// * `exclude` - exclude<br/>
    /// * `None` - None
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SkippedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exclude")]
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="only")]
        Only,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkippedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkippedEnum value)
        {
            return value switch
            {
                SkippedEnum.Exclude => "exclude",
                SkippedEnum.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkippedEnum? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => SkippedEnum.Exclude,
                "only" => SkippedEnum.Only,
                _ => null,
            };
        }
    }
}