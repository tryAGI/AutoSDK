//HintName: G.Models.ServerlessListRequestsByEndpointSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort results by end time or duration<br/>
    /// Default Value: ended_at<br/>
    /// Example: ended_at
    /// </summary>
    public enum ServerlessListRequestsByEndpointSortBy
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
    public static class ServerlessListRequestsByEndpointSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointSortBy value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointSortBy.Duration => "duration",
                ServerlessListRequestsByEndpointSortBy.EndedAt => "ended_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointSortBy? ToEnum(string value)
        {
            return value switch
            {
                "duration" => ServerlessListRequestsByEndpointSortBy.Duration,
                "ended_at" => ServerlessListRequestsByEndpointSortBy.EndedAt,
                _ => null,
            };
        }
    }
}