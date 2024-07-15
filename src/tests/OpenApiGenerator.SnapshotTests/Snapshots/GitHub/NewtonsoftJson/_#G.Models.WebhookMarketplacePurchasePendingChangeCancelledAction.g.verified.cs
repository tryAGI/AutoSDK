//HintName: G.Models.WebhookMarketplacePurchasePendingChangeCancelledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMarketplacePurchasePendingChangeCancelledAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending_change_cancelled")]
        PendingChangeCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchasePendingChangeCancelledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchasePendingChangeCancelledAction value)
        {
            return value switch
            {
                WebhookMarketplacePurchasePendingChangeCancelledAction.PendingChangeCancelled => "pending_change_cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchasePendingChangeCancelledAction? ToEnum(string value)
        {
            return value switch
            {
                "pending_change_cancelled" => WebhookMarketplacePurchasePendingChangeCancelledAction.PendingChangeCancelled,
                _ => null,
            };
        }
    }
}