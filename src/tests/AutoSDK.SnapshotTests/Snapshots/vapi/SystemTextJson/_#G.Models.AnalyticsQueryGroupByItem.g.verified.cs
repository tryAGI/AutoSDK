//HintName: G.Models.AnalyticsQueryGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsQueryGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        AnalysisSuccessEvaluation,
        /// <summary>
        /// 
        /// </summary>
        AssistantId,
        /// <summary>
        /// 
        /// </summary>
        EndedReason,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsQueryGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsQueryGroupByItem value)
        {
            return value switch
            {
                AnalyticsQueryGroupByItem.AnalysisSuccessEvaluation => "analysis.successEvaluation",
                AnalyticsQueryGroupByItem.AssistantId => "assistantId",
                AnalyticsQueryGroupByItem.EndedReason => "endedReason",
                AnalyticsQueryGroupByItem.Status => "status",
                AnalyticsQueryGroupByItem.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsQueryGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "analysis.successEvaluation" => AnalyticsQueryGroupByItem.AnalysisSuccessEvaluation,
                "assistantId" => AnalyticsQueryGroupByItem.AssistantId,
                "endedReason" => AnalyticsQueryGroupByItem.EndedReason,
                "status" => AnalyticsQueryGroupByItem.Status,
                "type" => AnalyticsQueryGroupByItem.Type,
                _ => null,
            };
        }
    }
}