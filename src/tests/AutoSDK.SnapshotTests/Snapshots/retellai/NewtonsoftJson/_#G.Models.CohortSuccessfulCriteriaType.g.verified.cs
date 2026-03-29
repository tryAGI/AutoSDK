//HintName: G.Models.CohortSuccessfulCriteriaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the filter
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CohortSuccessfulCriteriaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortSuccessfulCriteriaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortSuccessfulCriteriaType value)
        {
            return value switch
            {
                CohortSuccessfulCriteriaType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortSuccessfulCriteriaType? ToEnum(string value)
        {
            return value switch
            {
                "number" => CohortSuccessfulCriteriaType.Number,
                _ => null,
            };
        }
    }
}