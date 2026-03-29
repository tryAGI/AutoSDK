//HintName: G.Models.ReviewCriteriaEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `all` - Task is reviewed if all annotations are reviewed<br/>
    /// * `one` - Task is reviewed if at least one annotation is reviewed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReviewCriteriaEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one")]
        One,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewCriteriaEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewCriteriaEnum value)
        {
            return value switch
            {
                ReviewCriteriaEnum.All => "all",
                ReviewCriteriaEnum.One => "one",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewCriteriaEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReviewCriteriaEnum.All,
                "one" => ReviewCriteriaEnum.One,
                _ => null,
            };
        }
    }
}