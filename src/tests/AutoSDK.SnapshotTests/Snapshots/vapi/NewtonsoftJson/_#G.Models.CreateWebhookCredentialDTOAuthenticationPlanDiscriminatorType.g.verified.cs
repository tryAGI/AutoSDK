//HintName: G.Models.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType
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
    public static class CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType value)
        {
            return value switch
            {
                CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Bearer => "bearer",
                CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Hmac => "hmac",
                CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Bearer,
                "hmac" => CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Hmac,
                "oauth2" => CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}