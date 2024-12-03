//HintName: G.Models.FinetuneJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Compressing,
        /// <summary>
        /// 
        /// </summary>
        Uploading,
        /// <summary>
        /// 
        /// </summary>
        CancelRequested,
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
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneJobStatus value)
        {
            return value switch
            {
                FinetuneJobStatus.Pending => "pending",
                FinetuneJobStatus.Queued => "queued",
                FinetuneJobStatus.Running => "running",
                FinetuneJobStatus.Compressing => "compressing",
                FinetuneJobStatus.Uploading => "uploading",
                FinetuneJobStatus.CancelRequested => "cancel_requested",
                FinetuneJobStatus.Cancelled => "cancelled",
                FinetuneJobStatus.Error => "error",
                FinetuneJobStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => FinetuneJobStatus.Pending,
                "queued" => FinetuneJobStatus.Queued,
                "running" => FinetuneJobStatus.Running,
                "compressing" => FinetuneJobStatus.Compressing,
                "uploading" => FinetuneJobStatus.Uploading,
                "cancel_requested" => FinetuneJobStatus.CancelRequested,
                "cancelled" => FinetuneJobStatus.Cancelled,
                "error" => FinetuneJobStatus.Error,
                "completed" => FinetuneJobStatus.Completed,
                _ => null,
            };
        }
    }
}