//HintName: G.Models.WebhookCredentialAuthenticationPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCredentialAuthenticationPlanDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bearer")]
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hmac")]
        Hmac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth2")]
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCredentialAuthenticationPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCredentialAuthenticationPlanDiscriminatorType value)
        {
            return value switch
            {
                WebhookCredentialAuthenticationPlanDiscriminatorType.Bearer => "bearer",
                WebhookCredentialAuthenticationPlanDiscriminatorType.Hmac => "hmac",
                WebhookCredentialAuthenticationPlanDiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCredentialAuthenticationPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => WebhookCredentialAuthenticationPlanDiscriminatorType.Bearer,
                "hmac" => WebhookCredentialAuthenticationPlanDiscriminatorType.Hmac,
                "oauth2" => WebhookCredentialAuthenticationPlanDiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}