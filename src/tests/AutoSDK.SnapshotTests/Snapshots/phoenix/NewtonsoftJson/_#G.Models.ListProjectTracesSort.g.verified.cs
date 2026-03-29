//HintName: G.Models.ListProjectTracesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort field<br/>
    /// Default Value: start_time
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListProjectTracesSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_ms")]
        LatencyMs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="start_time")]
        StartTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectTracesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectTracesSort value)
        {
            return value switch
            {
                ListProjectTracesSort.LatencyMs => "latency_ms",
                ListProjectTracesSort.StartTime => "start_time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectTracesSort? ToEnum(string value)
        {
            return value switch
            {
                "latency_ms" => ListProjectTracesSort.LatencyMs,
                "start_time" => ListProjectTracesSort.StartTime,
                _ => null,
            };
        }
    }
}