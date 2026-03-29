//HintName: G.Models.CreateComputeInstanceResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current operational status of the instance<br/>
    /// Example: ready
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateComputeInstanceResponseStatus
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
    public static class CreateComputeInstanceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseStatus value)
        {
            return value switch
            {
                CreateComputeInstanceResponseStatus.Init => "init",
                CreateComputeInstanceResponseStatus.Pending => "pending",
                CreateComputeInstanceResponseStatus.Provisioning => "provisioning",
                CreateComputeInstanceResponseStatus.Ready => "ready",
                CreateComputeInstanceResponseStatus.Stopped => "stopped",
                CreateComputeInstanceResponseStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "init" => CreateComputeInstanceResponseStatus.Init,
                "pending" => CreateComputeInstanceResponseStatus.Pending,
                "provisioning" => CreateComputeInstanceResponseStatus.Provisioning,
                "ready" => CreateComputeInstanceResponseStatus.Ready,
                "stopped" => CreateComputeInstanceResponseStatus.Stopped,
                "unknown" => CreateComputeInstanceResponseStatus.Unknown,
                _ => null,
            };
        }
    }
}