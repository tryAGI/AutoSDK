//HintName: G.Models.BetaMessageBatchProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Processing status of the Message Batch.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaMessageBatchProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canceling")]
        Canceling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ended")]
        Ended,
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
                BetaMessageBatchProcessingStatus.InProgress => "in_progress",
                BetaMessageBatchProcessingStatus.Canceling => "canceling",
                BetaMessageBatchProcessingStatus.Ended => "ended",
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
                "in_progress" => BetaMessageBatchProcessingStatus.InProgress,
                "canceling" => BetaMessageBatchProcessingStatus.Canceling,
                "ended" => BetaMessageBatchProcessingStatus.Ended,
                _ => null,
            };
        }
    }
}