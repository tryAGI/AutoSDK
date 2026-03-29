//HintName: G.Models.PatchWebhookSubscriptionsByIdResponseVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook payload version
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchWebhookSubscriptionsByIdResponseVersion
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
    public static class PatchWebhookSubscriptionsByIdResponseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWebhookSubscriptionsByIdResponseVersion value)
        {
            return value switch
            {
                PatchWebhookSubscriptionsByIdResponseVersion.V1 => "V1",
                PatchWebhookSubscriptionsByIdResponseVersion.V2 => "V2",
                PatchWebhookSubscriptionsByIdResponseVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWebhookSubscriptionsByIdResponseVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => PatchWebhookSubscriptionsByIdResponseVersion.V1,
                "V2" => PatchWebhookSubscriptionsByIdResponseVersion.V2,
                "V3" => PatchWebhookSubscriptionsByIdResponseVersion.V3,
                _ => null,
            };
        }
    }
}