//HintName: G.Models.NodeStatusStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Node's status.<br/>
    /// Default Value: HEALTHY
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NodeStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HEALTHY")]
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INDEXING")]
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TIMEOUT")]
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNAVAILABLE")]
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNHEALTHY")]
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