//HintName: G.Models.PostWebhookSubscriptionsRequestVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook payload version<br/>
    /// Default Value: V3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostWebhookSubscriptionsRequestVersion
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
    public static class PostWebhookSubscriptionsRequestVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostWebhookSubscriptionsRequestVersion value)
        {
            return value switch
            {
                PostWebhookSubscriptionsRequestVersion.V1 => "V1",
                PostWebhookSubscriptionsRequestVersion.V2 => "V2",
                PostWebhookSubscriptionsRequestVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostWebhookSubscriptionsRequestVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => PostWebhookSubscriptionsRequestVersion.V1,
                "V2" => PostWebhookSubscriptionsRequestVersion.V2,
                "V3" => PostWebhookSubscriptionsRequestVersion.V3,
                _ => null,
            };
        }
    }
}