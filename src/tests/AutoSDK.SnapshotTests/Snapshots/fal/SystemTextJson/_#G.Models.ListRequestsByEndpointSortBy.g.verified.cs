//HintName: G.Models.ListRequestsByEndpointSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort results by end time or duration<br/>
    /// Default Value: ended_at<br/>
    /// Example: ended_at
    /// </summary>
    public enum ListRequestsByEndpointSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        EndedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRequestsByEndpointSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointSortBy value)
        {
            return value switch
            {
                ListRequestsByEndpointSortBy.Duration => "duration",
                ListRequestsByEndpointSortBy.EndedAt => "ended_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointSortBy? ToEnum(string value)
        {
            return value switch
            {
                "duration" => ListRequestsByEndpointSortBy.Duration,
                "ended_at" => ListRequestsByEndpointSortBy.EndedAt,
                _ => null,
            };
        }
    }
}