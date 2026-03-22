//HintName: G.Models.CheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check suite is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check suites.<br/>
    /// Example: completed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckSuiteStatus
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
    public static class CheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckSuiteStatus value)
        {
            return value switch
            {
                CheckSuiteStatus.Completed => "completed",
                CheckSuiteStatus.InProgress => "in_progress",
                CheckSuiteStatus.Pending => "pending",
                CheckSuiteStatus.Queued => "queued",
                CheckSuiteStatus.Requested => "requested",
                CheckSuiteStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CheckSuiteStatus.Completed,
                "in_progress" => CheckSuiteStatus.InProgress,
                "pending" => CheckSuiteStatus.Pending,
                "queued" => CheckSuiteStatus.Queued,
                "requested" => CheckSuiteStatus.Requested,
                "waiting" => CheckSuiteStatus.Waiting,
                _ => null,
            };
        }
    }
}