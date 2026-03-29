//HintName: G.Models.LocalRunnerJobResultRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalRunnerJobResultRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalRunnerJobResultRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalRunnerJobResultRequestStatus value)
        {
            return value switch
            {
                LocalRunnerJobResultRequestStatus.Cancelled => "cancelled",
                LocalRunnerJobResultRequestStatus.Completed => "completed",
                LocalRunnerJobResultRequestStatus.Failed => "failed",
                LocalRunnerJobResultRequestStatus.Pending => "pending",
                LocalRunnerJobResultRequestStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalRunnerJobResultRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => LocalRunnerJobResultRequestStatus.Cancelled,
                "completed" => LocalRunnerJobResultRequestStatus.Completed,
                "failed" => LocalRunnerJobResultRequestStatus.Failed,
                "pending" => LocalRunnerJobResultRequestStatus.Pending,
                "running" => LocalRunnerJobResultRequestStatus.Running,
                _ => null,
            };
        }
    }
}