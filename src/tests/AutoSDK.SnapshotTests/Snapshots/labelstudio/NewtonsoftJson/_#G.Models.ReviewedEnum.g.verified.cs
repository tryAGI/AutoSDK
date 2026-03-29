//HintName: G.Models.ReviewedEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `only` - only<br/>
    /// * `exclude` - exclude<br/>
    /// * `None` - None
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReviewedEnum
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
    public static class ReviewedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewedEnum value)
        {
            return value switch
            {
                ReviewedEnum.Exclude => "exclude",
                ReviewedEnum.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewedEnum? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => ReviewedEnum.Exclude,
                "only" => ReviewedEnum.Only,
                _ => null,
            };
        }
    }
}