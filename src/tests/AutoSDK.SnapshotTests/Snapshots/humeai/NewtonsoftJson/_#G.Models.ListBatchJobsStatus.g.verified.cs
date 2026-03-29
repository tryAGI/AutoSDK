//HintName: G.Models.ListBatchJobsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListBatchJobsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchJobsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchJobsStatus value)
        {
            return value switch
            {
                ListBatchJobsStatus.Completed => "COMPLETED",
                ListBatchJobsStatus.Failed => "FAILED",
                ListBatchJobsStatus.InProgress => "IN_PROGRESS",
                ListBatchJobsStatus.Queued => "QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchJobsStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ListBatchJobsStatus.Completed,
                "FAILED" => ListBatchJobsStatus.Failed,
                "IN_PROGRESS" => ListBatchJobsStatus.InProgress,
                "QUEUED" => ListBatchJobsStatus.Queued,
                _ => null,
            };
        }
    }
}