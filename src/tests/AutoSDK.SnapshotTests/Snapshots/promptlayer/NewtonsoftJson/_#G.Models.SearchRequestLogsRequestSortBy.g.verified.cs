//HintName: G.Models.SearchRequestLogsRequestSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Field to sort results by.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchRequestLogsRequestSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_tokens")]
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_ms")]
        LatencyMs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_tokens")]
        OutputTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="request_start_time")]
        RequestStartTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestLogsRequestSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestLogsRequestSortBy value)
        {
            return value switch
            {
                SearchRequestLogsRequestSortBy.Cost => "cost",
                SearchRequestLogsRequestSortBy.InputTokens => "input_tokens",
                SearchRequestLogsRequestSortBy.LatencyMs => "latency_ms",
                SearchRequestLogsRequestSortBy.OutputTokens => "output_tokens",
                SearchRequestLogsRequestSortBy.RequestStartTime => "request_start_time",
                SearchRequestLogsRequestSortBy.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestLogsRequestSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => SearchRequestLogsRequestSortBy.Cost,
                "input_tokens" => SearchRequestLogsRequestSortBy.InputTokens,
                "latency_ms" => SearchRequestLogsRequestSortBy.LatencyMs,
                "output_tokens" => SearchRequestLogsRequestSortBy.OutputTokens,
                "request_start_time" => SearchRequestLogsRequestSortBy.RequestStartTime,
                "status" => SearchRequestLogsRequestSortBy.Status,
                _ => null,
            };
        }
    }
}