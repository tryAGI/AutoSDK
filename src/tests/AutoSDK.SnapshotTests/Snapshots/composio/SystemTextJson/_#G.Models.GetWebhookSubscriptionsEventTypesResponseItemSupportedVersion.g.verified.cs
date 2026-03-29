//HintName: G.Models.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion
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
    public static class GetWebhookSubscriptionsEventTypesResponseItemSupportedVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion value)
        {
            return value switch
            {
                GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion.V1 => "V1",
                GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion.V2 => "V2",
                GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion.V1,
                "V2" => GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion.V2,
                "V3" => GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion.V3,
                _ => null,
            };
        }
    }
}