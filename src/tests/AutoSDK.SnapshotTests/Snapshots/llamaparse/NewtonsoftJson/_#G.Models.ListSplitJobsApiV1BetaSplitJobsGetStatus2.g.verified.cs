//HintName: G.Models.ListSplitJobsApiV1BetaSplitJobsGetStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListSplitJobsApiV1BetaSplitJobsGetStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSplitJobsApiV1BetaSplitJobsGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSplitJobsApiV1BetaSplitJobsGetStatus2 value)
        {
            return value switch
            {
                ListSplitJobsApiV1BetaSplitJobsGetStatus2.Cancelled => "cancelled",
                ListSplitJobsApiV1BetaSplitJobsGetStatus2.Completed => "completed",
                ListSplitJobsApiV1BetaSplitJobsGetStatus2.Failed => "failed",
                ListSplitJobsApiV1BetaSplitJobsGetStatus2.Pending => "pending",
                ListSplitJobsApiV1BetaSplitJobsGetStatus2.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSplitJobsApiV1BetaSplitJobsGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ListSplitJobsApiV1BetaSplitJobsGetStatus2.Cancelled,
                "completed" => ListSplitJobsApiV1BetaSplitJobsGetStatus2.Completed,
                "failed" => ListSplitJobsApiV1BetaSplitJobsGetStatus2.Failed,
                "pending" => ListSplitJobsApiV1BetaSplitJobsGetStatus2.Pending,
                "processing" => ListSplitJobsApiV1BetaSplitJobsGetStatus2.Processing,
                _ => null,
            };
        }
    }
}