//HintName: G.Models.GetWebhookSubscriptionsResponseItemVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook payload version
    /// </summary>
    public enum GetWebhookSubscriptionsResponseItemVersion
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
    public static class GetWebhookSubscriptionsResponseItemVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhookSubscriptionsResponseItemVersion value)
        {
            return value switch
            {
                GetWebhookSubscriptionsResponseItemVersion.V1 => "V1",
                GetWebhookSubscriptionsResponseItemVersion.V2 => "V2",
                GetWebhookSubscriptionsResponseItemVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhookSubscriptionsResponseItemVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => GetWebhookSubscriptionsResponseItemVersion.V1,
                "V2" => GetWebhookSubscriptionsResponseItemVersion.V2,
                "V3" => GetWebhookSubscriptionsResponseItemVersion.V3,
                _ => null,
            };
        }
    }
}