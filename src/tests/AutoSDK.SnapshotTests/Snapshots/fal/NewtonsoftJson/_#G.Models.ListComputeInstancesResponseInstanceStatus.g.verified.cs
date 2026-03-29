//HintName: G.Models.ListComputeInstancesResponseInstanceStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current operational status of the instance<br/>
    /// Example: ready
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListComputeInstancesResponseInstanceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="init")]
        Init,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="provisioning")]
        Provisioning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stopped")]
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListComputeInstancesResponseInstanceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseInstanceStatus value)
        {
            return value switch
            {
                ListComputeInstancesResponseInstanceStatus.Init => "init",
                ListComputeInstancesResponseInstanceStatus.Pending => "pending",
                ListComputeInstancesResponseInstanceStatus.Provisioning => "provisioning",
                ListComputeInstancesResponseInstanceStatus.Ready => "ready",
                ListComputeInstancesResponseInstanceStatus.Stopped => "stopped",
                ListComputeInstancesResponseInstanceStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseInstanceStatus? ToEnum(string value)
        {
            return value switch
            {
                "init" => ListComputeInstancesResponseInstanceStatus.Init,
                "pending" => ListComputeInstancesResponseInstanceStatus.Pending,
                "provisioning" => ListComputeInstancesResponseInstanceStatus.Provisioning,
                "ready" => ListComputeInstancesResponseInstanceStatus.Ready,
                "stopped" => ListComputeInstancesResponseInstanceStatus.Stopped,
                "unknown" => ListComputeInstancesResponseInstanceStatus.Unknown,
                _ => null,
            };
        }
    }
}