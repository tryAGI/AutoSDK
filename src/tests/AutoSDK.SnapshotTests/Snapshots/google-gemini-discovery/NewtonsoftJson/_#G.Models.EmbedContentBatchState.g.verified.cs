//HintName: G.Models.EmbedContentBatchState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output only. The state of the batch.<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedContentBatchState
    {
        /// <summary>
        /// The batch has been cancelled.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BATCH_STATE_CANCELLED")]
        BatchStateCancelled,
        /// <summary>
        /// The batch has expired.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BATCH_STATE_EXPIRED")]
        BatchStateExpired,
        /// <summary>
        /// The batch failed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BATCH_STATE_FAILED")]
        BatchStateFailed,
        /// <summary>
        /// The service is preparing to run the batch.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BATCH_STATE_PENDING")]
        BatchStatePending,
        /// <summary>
        /// The batch is in progress.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BATCH_STATE_RUNNING")]
        BatchStateRunning,
        /// <summary>
        /// The batch completed successfully.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BATCH_STATE_SUCCEEDED")]
        BatchStateSucceeded,
        /// <summary>
        /// The batch state is unspecified.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BATCH_STATE_UNSPECIFIED")]
        BatchStateUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedContentBatchStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedContentBatchState value)
        {
            return value switch
            {
                EmbedContentBatchState.BatchStateCancelled => "BATCH_STATE_CANCELLED",
                EmbedContentBatchState.BatchStateExpired => "BATCH_STATE_EXPIRED",
                EmbedContentBatchState.BatchStateFailed => "BATCH_STATE_FAILED",
                EmbedContentBatchState.BatchStatePending => "BATCH_STATE_PENDING",
                EmbedContentBatchState.BatchStateRunning => "BATCH_STATE_RUNNING",
                EmbedContentBatchState.BatchStateSucceeded => "BATCH_STATE_SUCCEEDED",
                EmbedContentBatchState.BatchStateUnspecified => "BATCH_STATE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedContentBatchState? ToEnum(string value)
        {
            return value switch
            {
                "BATCH_STATE_CANCELLED" => EmbedContentBatchState.BatchStateCancelled,
                "BATCH_STATE_EXPIRED" => EmbedContentBatchState.BatchStateExpired,
                "BATCH_STATE_FAILED" => EmbedContentBatchState.BatchStateFailed,
                "BATCH_STATE_PENDING" => EmbedContentBatchState.BatchStatePending,
                "BATCH_STATE_RUNNING" => EmbedContentBatchState.BatchStateRunning,
                "BATCH_STATE_SUCCEEDED" => EmbedContentBatchState.BatchStateSucceeded,
                "BATCH_STATE_UNSPECIFIED" => EmbedContentBatchState.BatchStateUnspecified,
                _ => null,
            };
        }
    }
}