//HintName: G.Models.GetComputeInstanceResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current operational status of the instance<br/>
    /// Example: ready
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetComputeInstanceResponseStatus
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
    public static class GetComputeInstanceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseStatus value)
        {
            return value switch
            {
                GetComputeInstanceResponseStatus.Init => "init",
                GetComputeInstanceResponseStatus.Pending => "pending",
                GetComputeInstanceResponseStatus.Provisioning => "provisioning",
                GetComputeInstanceResponseStatus.Ready => "ready",
                GetComputeInstanceResponseStatus.Stopped => "stopped",
                GetComputeInstanceResponseStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "init" => GetComputeInstanceResponseStatus.Init,
                "pending" => GetComputeInstanceResponseStatus.Pending,
                "provisioning" => GetComputeInstanceResponseStatus.Provisioning,
                "ready" => GetComputeInstanceResponseStatus.Ready,
                "stopped" => GetComputeInstanceResponseStatus.Stopped,
                "unknown" => GetComputeInstanceResponseStatus.Unknown,
                _ => null,
            };
        }
    }
}