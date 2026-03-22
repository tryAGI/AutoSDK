//HintName: G.Models.FinetuneJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinetuneJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancel_requested")]
        CancelRequested,
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
        [global::System.Runtime.Serialization.EnumMember(Value="compressing")]
        Compressing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
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
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploading")]
        Uploading,
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
                FinetuneJobStatus.CancelRequested => "cancel_requested",
                FinetuneJobStatus.Cancelled => "cancelled",
                FinetuneJobStatus.Completed => "completed",
                FinetuneJobStatus.Compressing => "compressing",
                FinetuneJobStatus.Error => "error",
                FinetuneJobStatus.Pending => "pending",
                FinetuneJobStatus.Queued => "queued",
                FinetuneJobStatus.Running => "running",
                FinetuneJobStatus.Uploading => "uploading",
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
                "cancel_requested" => FinetuneJobStatus.CancelRequested,
                "cancelled" => FinetuneJobStatus.Cancelled,
                "completed" => FinetuneJobStatus.Completed,
                "compressing" => FinetuneJobStatus.Compressing,
                "error" => FinetuneJobStatus.Error,
                "pending" => FinetuneJobStatus.Pending,
                "queued" => FinetuneJobStatus.Queued,
                "running" => FinetuneJobStatus.Running,
                "uploading" => FinetuneJobStatus.Uploading,
                _ => null,
            };
        }
    }
}