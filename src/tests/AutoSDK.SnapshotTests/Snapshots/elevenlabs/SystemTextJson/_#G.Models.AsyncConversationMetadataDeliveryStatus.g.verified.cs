//HintName: G.Models.AsyncConversationMetadataDeliveryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncConversationMetadataDeliveryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncConversationMetadataDeliveryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncConversationMetadataDeliveryStatus value)
        {
            return value switch
            {
                AsyncConversationMetadataDeliveryStatus.Failed => "failed",
                AsyncConversationMetadataDeliveryStatus.Pending => "pending",
                AsyncConversationMetadataDeliveryStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncConversationMetadataDeliveryStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AsyncConversationMetadataDeliveryStatus.Failed,
                "pending" => AsyncConversationMetadataDeliveryStatus.Pending,
                "success" => AsyncConversationMetadataDeliveryStatus.Success,
                _ => null,
            };
        }
    }
}