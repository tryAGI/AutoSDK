//HintName: G.Models.UpdateEvaluationStatusRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateEvaluationStatusRequestStatus
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
    public static class UpdateEvaluationStatusRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEvaluationStatusRequestStatus value)
        {
            return value switch
            {
                UpdateEvaluationStatusRequestStatus.Cancelled => "cancelled",
                UpdateEvaluationStatusRequestStatus.Completed => "completed",
                UpdateEvaluationStatusRequestStatus.Failed => "failed",
                UpdateEvaluationStatusRequestStatus.Pending => "pending",
                UpdateEvaluationStatusRequestStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEvaluationStatusRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => UpdateEvaluationStatusRequestStatus.Cancelled,
                "completed" => UpdateEvaluationStatusRequestStatus.Completed,
                "failed" => UpdateEvaluationStatusRequestStatus.Failed,
                "pending" => UpdateEvaluationStatusRequestStatus.Pending,
                "running" => UpdateEvaluationStatusRequestStatus.Running,
                _ => null,
            };
        }
    }
}