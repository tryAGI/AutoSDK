//HintName: G.Models.PostWebhookSubscriptionsResponseVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook payload version
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostWebhookSubscriptionsResponseVersion
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
    public static class PostWebhookSubscriptionsResponseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostWebhookSubscriptionsResponseVersion value)
        {
            return value switch
            {
                PostWebhookSubscriptionsResponseVersion.V1 => "V1",
                PostWebhookSubscriptionsResponseVersion.V2 => "V2",
                PostWebhookSubscriptionsResponseVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostWebhookSubscriptionsResponseVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => PostWebhookSubscriptionsResponseVersion.V1,
                "V2" => PostWebhookSubscriptionsResponseVersion.V2,
                "V3" => PostWebhookSubscriptionsResponseVersion.V3,
                _ => null,
            };
        }
    }
}