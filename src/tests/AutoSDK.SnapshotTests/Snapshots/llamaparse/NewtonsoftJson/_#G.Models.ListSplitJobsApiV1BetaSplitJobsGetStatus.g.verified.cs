//HintName: G.Models.ListSplitJobsApiV1BetaSplitJobsGetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListSplitJobsApiV1BetaSplitJobsGetStatus
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
    public static class ListSplitJobsApiV1BetaSplitJobsGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSplitJobsApiV1BetaSplitJobsGetStatus value)
        {
            return value switch
            {
                ListSplitJobsApiV1BetaSplitJobsGetStatus.Cancelled => "cancelled",
                ListSplitJobsApiV1BetaSplitJobsGetStatus.Completed => "completed",
                ListSplitJobsApiV1BetaSplitJobsGetStatus.Failed => "failed",
                ListSplitJobsApiV1BetaSplitJobsGetStatus.Pending => "pending",
                ListSplitJobsApiV1BetaSplitJobsGetStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSplitJobsApiV1BetaSplitJobsGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ListSplitJobsApiV1BetaSplitJobsGetStatus.Cancelled,
                "completed" => ListSplitJobsApiV1BetaSplitJobsGetStatus.Completed,
                "failed" => ListSplitJobsApiV1BetaSplitJobsGetStatus.Failed,
                "pending" => ListSplitJobsApiV1BetaSplitJobsGetStatus.Pending,
                "processing" => ListSplitJobsApiV1BetaSplitJobsGetStatus.Processing,
                _ => null,
            };
        }
    }
}