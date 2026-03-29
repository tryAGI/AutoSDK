//HintName: G.Models.GetWebhookSubscriptionsByIdResponseVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook payload version
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetWebhookSubscriptionsByIdResponseVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V1")]
        V1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V2")]
        V2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V3")]
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWebhookSubscriptionsByIdResponseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhookSubscriptionsByIdResponseVersion value)
        {
            return value switch
            {
                GetWebhookSubscriptionsByIdResponseVersion.V1 => "V1",
                GetWebhookSubscriptionsByIdResponseVersion.V2 => "V2",
                GetWebhookSubscriptionsByIdResponseVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhookSubscriptionsByIdResponseVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => GetWebhookSubscriptionsByIdResponseVersion.V1,
                "V2" => GetWebhookSubscriptionsByIdResponseVersion.V2,
                "V3" => GetWebhookSubscriptionsByIdResponseVersion.V3,
                _ => null,
            };
        }
    }
}