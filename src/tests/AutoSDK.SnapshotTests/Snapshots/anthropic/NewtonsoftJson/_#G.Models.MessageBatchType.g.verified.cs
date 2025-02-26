//HintName: G.Models.MessageBatchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type.<br/>
    /// For Message Batches, this is always `"message_batch"`.<br/>
    /// Default Value: message_batch
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageBatchType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_batch")]
        MessageBatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageBatchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageBatchType value)
        {
            return value switch
            {
                MessageBatchType.MessageBatch => "message_batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageBatchType? ToEnum(string value)
        {
            return value switch
            {
                "message_batch" => MessageBatchType.MessageBatch,
                _ => null,
            };
        }
    }
}