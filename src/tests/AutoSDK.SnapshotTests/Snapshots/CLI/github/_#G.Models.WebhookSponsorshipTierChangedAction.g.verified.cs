//HintName: G.Models.WebhookSponsorshipTierChangedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSponsorshipTierChangedAction
    {
        /// <summary>
        /// 
        /// </summary>
        TierChanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSponsorshipTierChangedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSponsorshipTierChangedAction value)
        {
            return value switch
            {
                WebhookSponsorshipTierChangedAction.TierChanged => "tier_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSponsorshipTierChangedAction? ToEnum(string value)
        {
            return value switch
            {
                "tier_changed" => WebhookSponsorshipTierChangedAction.TierChanged,
                _ => null,
            };
        }
    }
}