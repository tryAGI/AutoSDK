//HintName: G.Models.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType
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
    public static class UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType value)
        {
            return value switch
            {
                UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Bearer => "bearer",
                UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Hmac => "hmac",
                UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Bearer,
                "hmac" => UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Hmac,
                "oauth2" => UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}