//HintName: G.Models.SessionInsightsDtoOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionInsightsDtoOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        Achieved,
        /// <summary>
        /// 
        /// </summary>
        NotAchieved,
        /// <summary>
        /// 
        /// </summary>
        PartiallyAchieved,
        /// <summary>
        /// 
        /// </summary>
        UnclearDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionInsightsDtoOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionInsightsDtoOutcome value)
        {
            return value switch
            {
                SessionInsightsDtoOutcome.Achieved => "Achieved",
                SessionInsightsDtoOutcome.NotAchieved => "Not achieved",
                SessionInsightsDtoOutcome.PartiallyAchieved => "Partially achieved",
                SessionInsightsDtoOutcome.UnclearDefinition => "Unclear-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionInsightsDtoOutcome? ToEnum(string value)
        {
            return value switch
            {
                "Achieved" => SessionInsightsDtoOutcome.Achieved,
                "Not achieved" => SessionInsightsDtoOutcome.NotAchieved,
                "Partially achieved" => SessionInsightsDtoOutcome.PartiallyAchieved,
                "Unclear-definition" => SessionInsightsDtoOutcome.UnclearDefinition,
                _ => null,
            };
        }
    }
}