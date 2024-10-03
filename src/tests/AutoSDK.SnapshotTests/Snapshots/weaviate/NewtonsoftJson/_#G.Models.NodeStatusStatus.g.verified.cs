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
        HEALTHY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNHEALTHY")]
        UNHEALTHY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNAVAILABLE")]
        UNAVAILABLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TIMEOUT")]
        TIMEOUT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INDEXING")]
        INDEXING,
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
                NodeStatusStatus.HEALTHY => "HEALTHY",
                NodeStatusStatus.UNHEALTHY => "UNHEALTHY",
                NodeStatusStatus.UNAVAILABLE => "UNAVAILABLE",
                NodeStatusStatus.TIMEOUT => "TIMEOUT",
                NodeStatusStatus.INDEXING => "INDEXING",
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
                "HEALTHY" => NodeStatusStatus.HEALTHY,
                "UNHEALTHY" => NodeStatusStatus.UNHEALTHY,
                "UNAVAILABLE" => NodeStatusStatus.UNAVAILABLE,
                "TIMEOUT" => NodeStatusStatus.TIMEOUT,
                "INDEXING" => NodeStatusStatus.INDEXING,
                _ => null,
            };
        }
    }
}