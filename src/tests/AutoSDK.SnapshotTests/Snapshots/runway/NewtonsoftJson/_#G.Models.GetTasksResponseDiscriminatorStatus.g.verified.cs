//HintName: G.Models.GetTasksResponseDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTasksResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCEEDED")]
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THROTTLED")]
        Throttled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTasksResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTasksResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetTasksResponseDiscriminatorStatus.Cancelled => "CANCELLED",
                GetTasksResponseDiscriminatorStatus.Failed => "FAILED",
                GetTasksResponseDiscriminatorStatus.Pending => "PENDING",
                GetTasksResponseDiscriminatorStatus.Running => "RUNNING",
                GetTasksResponseDiscriminatorStatus.Succeeded => "SUCCEEDED",
                GetTasksResponseDiscriminatorStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTasksResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => GetTasksResponseDiscriminatorStatus.Cancelled,
                "FAILED" => GetTasksResponseDiscriminatorStatus.Failed,
                "PENDING" => GetTasksResponseDiscriminatorStatus.Pending,
                "RUNNING" => GetTasksResponseDiscriminatorStatus.Running,
                "SUCCEEDED" => GetTasksResponseDiscriminatorStatus.Succeeded,
                "THROTTLED" => GetTasksResponseDiscriminatorStatus.Throttled,
                _ => null,
            };
        }
    }
}