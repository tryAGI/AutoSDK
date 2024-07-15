//HintName: G.Models.DeploymentStatusState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the status.<br/>
    /// Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeploymentStatusState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inactive")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentStatusState value)
        {
            return value switch
            {
                DeploymentStatusState.Error => "error",
                DeploymentStatusState.Failure => "failure",
                DeploymentStatusState.Inactive => "inactive",
                DeploymentStatusState.Pending => "pending",
                DeploymentStatusState.Success => "success",
                DeploymentStatusState.Queued => "queued",
                DeploymentStatusState.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentStatusState? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeploymentStatusState.Error,
                "failure" => DeploymentStatusState.Failure,
                "inactive" => DeploymentStatusState.Inactive,
                "pending" => DeploymentStatusState.Pending,
                "success" => DeploymentStatusState.Success,
                "queued" => DeploymentStatusState.Queued,
                "in_progress" => DeploymentStatusState.InProgress,
                _ => null,
            };
        }
    }
}