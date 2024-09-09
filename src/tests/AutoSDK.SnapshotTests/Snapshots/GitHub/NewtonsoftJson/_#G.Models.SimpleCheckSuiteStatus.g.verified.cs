//HintName: G.Models.SimpleCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: completed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimpleCheckSuiteStatus
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimpleCheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimpleCheckSuiteStatus value)
        {
            return value switch
            {
                SimpleCheckSuiteStatus.Queued => "queued",
                SimpleCheckSuiteStatus.InProgress => "in_progress",
                SimpleCheckSuiteStatus.Completed => "completed",
                SimpleCheckSuiteStatus.Pending => "pending",
                SimpleCheckSuiteStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimpleCheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => SimpleCheckSuiteStatus.Queued,
                "in_progress" => SimpleCheckSuiteStatus.InProgress,
                "completed" => SimpleCheckSuiteStatus.Completed,
                "pending" => SimpleCheckSuiteStatus.Pending,
                "waiting" => SimpleCheckSuiteStatus.Waiting,
                _ => null,
            };
        }
    }
}