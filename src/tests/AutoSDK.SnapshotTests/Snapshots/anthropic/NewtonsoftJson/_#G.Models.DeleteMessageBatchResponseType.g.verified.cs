//HintName: G.Models.DeleteMessageBatchResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deleted object type.<br/>
    /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
    /// Default Value: message_batch_deleted
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteMessageBatchResponseType
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
    public static class DeleteMessageBatchResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteMessageBatchResponseType value)
        {
            return value switch
            {
                DeleteMessageBatchResponseType.MessageBatchDeleted => "message_batch_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteMessageBatchResponseType? ToEnum(string value)
        {
            return value switch
            {
                "message_batch_deleted" => DeleteMessageBatchResponseType.MessageBatchDeleted,
                _ => null,
            };
        }
    }
}