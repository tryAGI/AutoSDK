//HintName: G.Models.MessageBatchProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Processing status of the Message Batch.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageBatchProcessingStatus
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageBatchProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageBatchProcessingStatus value)
        {
            return value switch
            {
                MessageBatchProcessingStatus.Canceling => "canceling",
                MessageBatchProcessingStatus.Ended => "ended",
                MessageBatchProcessingStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageBatchProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceling" => MessageBatchProcessingStatus.Canceling,
                "ended" => MessageBatchProcessingStatus.Ended,
                "in_progress" => MessageBatchProcessingStatus.InProgress,
                _ => null,
            };
        }
    }
}