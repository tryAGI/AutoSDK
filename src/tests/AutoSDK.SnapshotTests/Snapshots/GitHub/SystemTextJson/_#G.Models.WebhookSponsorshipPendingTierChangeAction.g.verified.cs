//HintName: G.Models.WebhookSponsorshipPendingTierChangeAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSponsorshipPendingTierChangeAction
    {
        /// <summary>
        /// 
        /// </summary>
        PendingTierChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSponsorshipPendingTierChangeActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSponsorshipPendingTierChangeAction value)
        {
            return value switch
            {
                WebhookSponsorshipPendingTierChangeAction.PendingTierChange => "pending_tier_change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSponsorshipPendingTierChangeAction? ToEnum(string value)
        {
            return value switch
            {
                "pending_tier_change" => WebhookSponsorshipPendingTierChangeAction.PendingTierChange,
                _ => null,
            };
        }
    }
}