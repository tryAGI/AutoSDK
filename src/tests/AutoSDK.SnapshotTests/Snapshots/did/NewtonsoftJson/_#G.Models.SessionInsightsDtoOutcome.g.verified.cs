//HintName: G.Models.SessionInsightsDtoOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionInsightsDtoOutcome
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