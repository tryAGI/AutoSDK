//HintName: G.Models.NodeStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NodeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="connecting")]
        NodeStatusConnecting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="draining")]
        NodeStatusDraining,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        NodeStatusReady,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unhealthy")]
        NodeStatusUnhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeStatus value)
        {
            return value switch
            {
                NodeStatus.NodeStatusConnecting => "connecting",
                NodeStatus.NodeStatusDraining => "draining",
                NodeStatus.NodeStatusReady => "ready",
                NodeStatus.NodeStatusUnhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeStatus? ToEnum(string value)
        {
            return value switch
            {
                "connecting" => NodeStatus.NodeStatusConnecting,
                "draining" => NodeStatus.NodeStatusDraining,
                "ready" => NodeStatus.NodeStatusReady,
                "unhealthy" => NodeStatus.NodeStatusUnhealthy,
                _ => null,
            };
        }
    }
}