//HintName: G.Models.BetaMessageBatchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type.<br/>
    /// For Message Batches, this is always `"message_batch"`.<br/>
    /// Default Value: message_batch
    /// </summary>
    public enum BetaMessageBatchType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageBatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageBatchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageBatchType value)
        {
            return value switch
            {
                BetaMessageBatchType.MessageBatch => "message_batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageBatchType? ToEnum(string value)
        {
            return value switch
            {
                "message_batch" => BetaMessageBatchType.MessageBatch,
                _ => null,
            };
        }
    }
}