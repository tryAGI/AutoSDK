//HintName: G.Models.BetaDeleteMessageBatchResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deleted object type.<br/>
    /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
    /// Default Value: message_batch_deleted
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaDeleteMessageBatchResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_batch_deleted")]
        MessageBatchDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDeleteMessageBatchResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDeleteMessageBatchResponseType value)
        {
            return value switch
            {
                BetaDeleteMessageBatchResponseType.MessageBatchDeleted => "message_batch_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDeleteMessageBatchResponseType? ToEnum(string value)
        {
            return value switch
            {
                "message_batch_deleted" => BetaDeleteMessageBatchResponseType.MessageBatchDeleted,
                _ => null,
            };
        }
    }
}