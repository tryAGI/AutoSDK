//HintName: G.Models.SessionSummaryDtoInsightsOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionSummaryDtoInsightsOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Achieved")]
        Achieved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Not achieved")]
        NotAchieved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Partially achieved")]
        PartiallyAchieved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unclear-definition")]
        UnclearDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionSummaryDtoInsightsOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionSummaryDtoInsightsOutcome value)
        {
            return value switch
            {
                SessionSummaryDtoInsightsOutcome.Achieved => "Achieved",
                SessionSummaryDtoInsightsOutcome.NotAchieved => "Not achieved",
                SessionSummaryDtoInsightsOutcome.PartiallyAchieved => "Partially achieved",
                SessionSummaryDtoInsightsOutcome.UnclearDefinition => "Unclear-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionSummaryDtoInsightsOutcome? ToEnum(string value)
        {
            return value switch
            {
                "Achieved" => SessionSummaryDtoInsightsOutcome.Achieved,
                "Not achieved" => SessionSummaryDtoInsightsOutcome.NotAchieved,
                "Partially achieved" => SessionSummaryDtoInsightsOutcome.PartiallyAchieved,
                "Unclear-definition" => SessionSummaryDtoInsightsOutcome.UnclearDefinition,
                _ => null,
            };
        }
    }
}