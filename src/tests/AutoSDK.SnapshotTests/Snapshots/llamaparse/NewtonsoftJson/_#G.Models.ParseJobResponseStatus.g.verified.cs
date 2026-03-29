//HintName: G.Models.ParseJobResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current job status: PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ParseJobResponseStatus
    {
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseJobResponseStatus value)
        {
            return value switch
            {
                ParseJobResponseStatus.Cancelled => "CANCELLED",
                ParseJobResponseStatus.Completed => "COMPLETED",
                ParseJobResponseStatus.Failed => "FAILED",
                ParseJobResponseStatus.Pending => "PENDING",
                ParseJobResponseStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ParseJobResponseStatus.Cancelled,
                "COMPLETED" => ParseJobResponseStatus.Completed,
                "FAILED" => ParseJobResponseStatus.Failed,
                "PENDING" => ParseJobResponseStatus.Pending,
                "RUNNING" => ParseJobResponseStatus.Running,
                _ => null,
            };
        }
    }
}