//HintName: G.Models.LocalRunnerJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalRunnerJobStatus
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
    public static class LocalRunnerJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalRunnerJobStatus value)
        {
            return value switch
            {
                LocalRunnerJobStatus.Cancelled => "cancelled",
                LocalRunnerJobStatus.Completed => "completed",
                LocalRunnerJobStatus.Failed => "failed",
                LocalRunnerJobStatus.Pending => "pending",
                LocalRunnerJobStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalRunnerJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => LocalRunnerJobStatus.Cancelled,
                "completed" => LocalRunnerJobStatus.Completed,
                "failed" => LocalRunnerJobStatus.Failed,
                "pending" => LocalRunnerJobStatus.Pending,
                "running" => LocalRunnerJobStatus.Running,
                _ => null,
            };
        }
    }
}