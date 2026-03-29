//HintName: G.Models.RunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatus value)
        {
            return value switch
            {
                RunStatus.Cancelled => "cancelled",
                RunStatus.Completed => "completed",
                RunStatus.Created => "created",
                RunStatus.Failed => "failed",
                RunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RunStatus.Cancelled,
                "completed" => RunStatus.Completed,
                "created" => RunStatus.Created,
                "failed" => RunStatus.Failed,
                "running" => RunStatus.Running,
                _ => null,
            };
        }
    }
}