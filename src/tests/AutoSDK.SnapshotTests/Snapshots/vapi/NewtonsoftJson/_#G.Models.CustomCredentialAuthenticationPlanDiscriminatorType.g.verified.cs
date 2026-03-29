//HintName: G.Models.CustomCredentialAuthenticationPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomCredentialAuthenticationPlanDiscriminatorType
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
    public static class CustomCredentialAuthenticationPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomCredentialAuthenticationPlanDiscriminatorType value)
        {
            return value switch
            {
                CustomCredentialAuthenticationPlanDiscriminatorType.Bearer => "bearer",
                CustomCredentialAuthenticationPlanDiscriminatorType.Hmac => "hmac",
                CustomCredentialAuthenticationPlanDiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomCredentialAuthenticationPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => CustomCredentialAuthenticationPlanDiscriminatorType.Bearer,
                "hmac" => CustomCredentialAuthenticationPlanDiscriminatorType.Hmac,
                "oauth2" => CustomCredentialAuthenticationPlanDiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}