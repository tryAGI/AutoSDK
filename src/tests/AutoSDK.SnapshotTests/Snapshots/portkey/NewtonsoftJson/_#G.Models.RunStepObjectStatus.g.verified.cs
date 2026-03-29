//HintName: G.Models.RunStepObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the run step, which can be either `in_progress`, `cancelled`, `failed`, `completed`, or `expired`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepObjectStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepObjectStatus value)
        {
            return value switch
            {
                RunStepObjectStatus.Cancelled => "cancelled",
                RunStepObjectStatus.Completed => "completed",
                RunStepObjectStatus.Expired => "expired",
                RunStepObjectStatus.Failed => "failed",
                RunStepObjectStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RunStepObjectStatus.Cancelled,
                "completed" => RunStepObjectStatus.Completed,
                "expired" => RunStepObjectStatus.Expired,
                "failed" => RunStepObjectStatus.Failed,
                "in_progress" => RunStepObjectStatus.InProgress,
                _ => null,
            };
        }
    }
}