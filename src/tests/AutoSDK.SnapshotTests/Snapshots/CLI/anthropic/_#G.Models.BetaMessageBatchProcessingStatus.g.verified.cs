//HintName: G.Models.BetaMessageBatchProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Processing status of the Message Batch.
    /// </summary>
    public enum BetaMessageBatchProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceling,
        /// <summary>
        /// 
        /// </summary>
        Ended,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageBatchProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageBatchProcessingStatus value)
        {
            return value switch
            {
                BetaMessageBatchProcessingStatus.Canceling => "canceling",
                BetaMessageBatchProcessingStatus.Ended => "ended",
                BetaMessageBatchProcessingStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageBatchProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceling" => BetaMessageBatchProcessingStatus.Canceling,
                "ended" => BetaMessageBatchProcessingStatus.Ended,
                "in_progress" => BetaMessageBatchProcessingStatus.InProgress,
                _ => null,
            };
        }
    }
}