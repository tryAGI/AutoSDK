//HintName: G.Models.AnalyticsQueryGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnalyticsQueryGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analysis.successEvaluation")]
        AnalysisSuccessEvaluation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistantId")]
        AssistantId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="endedReason")]
        EndedReason,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="type")]
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