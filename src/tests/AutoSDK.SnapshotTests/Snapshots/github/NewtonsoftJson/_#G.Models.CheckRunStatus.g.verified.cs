//HintName: G.Models.CheckRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check runs.<br/>
    /// Example: queued
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckRunStatus value)
        {
            return value switch
            {
                CheckRunStatus.Completed => "completed",
                CheckRunStatus.InProgress => "in_progress",
                CheckRunStatus.Pending => "pending",
                CheckRunStatus.Queued => "queued",
                CheckRunStatus.Requested => "requested",
                CheckRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CheckRunStatus.Completed,
                "in_progress" => CheckRunStatus.InProgress,
                "pending" => CheckRunStatus.Pending,
                "queued" => CheckRunStatus.Queued,
                "requested" => CheckRunStatus.Requested,
                "waiting" => CheckRunStatus.Waiting,
                _ => null,
            };
        }
    }
}