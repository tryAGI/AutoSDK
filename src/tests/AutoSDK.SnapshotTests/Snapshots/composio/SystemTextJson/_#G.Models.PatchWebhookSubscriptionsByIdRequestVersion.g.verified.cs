//HintName: G.Models.PatchWebhookSubscriptionsByIdRequestVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook payload version
    /// </summary>
    public enum PatchWebhookSubscriptionsByIdRequestVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchWebhookSubscriptionsByIdRequestVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWebhookSubscriptionsByIdRequestVersion value)
        {
            return value switch
            {
                PatchWebhookSubscriptionsByIdRequestVersion.V1 => "V1",
                PatchWebhookSubscriptionsByIdRequestVersion.V2 => "V2",
                PatchWebhookSubscriptionsByIdRequestVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWebhookSubscriptionsByIdRequestVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => PatchWebhookSubscriptionsByIdRequestVersion.V1,
                "V2" => PatchWebhookSubscriptionsByIdRequestVersion.V2,
                "V3" => PatchWebhookSubscriptionsByIdRequestVersion.V3,
                _ => null,
            };
        }
    }
}