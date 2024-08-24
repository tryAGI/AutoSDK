//HintName: G.Models.JobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the current task.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        PENDING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        COMPLETE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        FAILED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatus value)
        {
            return value switch
            {
                JobStatus.PENDING => "PENDING",
                JobStatus.COMPLETE => "COMPLETE",
                JobStatus.FAILED => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatus? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => JobStatus.PENDING,
                "COMPLETE" => JobStatus.COMPLETE,
                "FAILED" => JobStatus.FAILED,
                _ => null,
            };
        }
    }
}