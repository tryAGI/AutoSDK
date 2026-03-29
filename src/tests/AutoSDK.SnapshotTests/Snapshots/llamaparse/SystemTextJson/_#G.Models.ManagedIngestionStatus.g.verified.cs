//HintName: G.Models.ManagedIngestionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of managed ingestion with partial Updates.
    /// </summary>
    public enum ManagedIngestionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        PartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedIngestionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedIngestionStatus value)
        {
            return value switch
            {
                ManagedIngestionStatus.Cancelled => "CANCELLED",
                ManagedIngestionStatus.Error => "ERROR",
                ManagedIngestionStatus.InProgress => "IN_PROGRESS",
                ManagedIngestionStatus.NotStarted => "NOT_STARTED",
                ManagedIngestionStatus.PartialSuccess => "PARTIAL_SUCCESS",
                ManagedIngestionStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedIngestionStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ManagedIngestionStatus.Cancelled,
                "ERROR" => ManagedIngestionStatus.Error,
                "IN_PROGRESS" => ManagedIngestionStatus.InProgress,
                "NOT_STARTED" => ManagedIngestionStatus.NotStarted,
                "PARTIAL_SUCCESS" => ManagedIngestionStatus.PartialSuccess,
                "SUCCESS" => ManagedIngestionStatus.Success,
                _ => null,
            };
        }
    }
}