//HintName: G.Models.NodeStatusStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Node's status.<br/>
    /// Default Value: HEALTHY
    /// </summary>
    public enum NodeStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeStatusStatus value)
        {
            return value switch
            {
                NodeStatusStatus.Healthy => "HEALTHY",
                NodeStatusStatus.Indexing => "INDEXING",
                NodeStatusStatus.Timeout => "TIMEOUT",
                NodeStatusStatus.Unavailable => "UNAVAILABLE",
                NodeStatusStatus.Unhealthy => "UNHEALTHY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "HEALTHY" => NodeStatusStatus.Healthy,
                "INDEXING" => NodeStatusStatus.Indexing,
                "TIMEOUT" => NodeStatusStatus.Timeout,
                "UNAVAILABLE" => NodeStatusStatus.Unavailable,
                "UNHEALTHY" => NodeStatusStatus.Unhealthy,
                _ => null,
            };
        }
    }
}