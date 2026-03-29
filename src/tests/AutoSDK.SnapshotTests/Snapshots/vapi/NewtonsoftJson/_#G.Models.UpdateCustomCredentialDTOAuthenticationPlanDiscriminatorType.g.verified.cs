//HintName: G.Models.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType
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
    public static class UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType value)
        {
            return value switch
            {
                UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Bearer => "bearer",
                UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Hmac => "hmac",
                UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Bearer,
                "hmac" => UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Hmac,
                "oauth2" => UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}