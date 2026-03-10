//HintName: G.Models.AsyncConversationMetadataDeliveryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AsyncConversationMetadataDeliveryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
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
                AsyncConversationMetadataDeliveryStatus.Pending => "pending",
                AsyncConversationMetadataDeliveryStatus.Success => "success",
                AsyncConversationMetadataDeliveryStatus.Failed => "failed",
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
                "pending" => AsyncConversationMetadataDeliveryStatus.Pending,
                "success" => AsyncConversationMetadataDeliveryStatus.Success,
                "failed" => AsyncConversationMetadataDeliveryStatus.Failed,
                _ => null,
            };
        }
    }
}