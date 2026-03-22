//HintName: G.Models.AuthorizationMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthorizationMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_header")]
        AuthorizationHeader,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="genesys_api_key")]
        GenesysApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid")]
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="livekit_token")]
        LivekitToken,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="livekit_token_website")]
        LivekitTokenWebsite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shareable_link")]
        ShareableLink,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signed_url")]
        SignedUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whatsapp")]
        Whatsapp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorizationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorizationMethod value)
        {
            return value switch
            {
                AuthorizationMethod.AuthorizationHeader => "authorization_header",
                AuthorizationMethod.GenesysApiKey => "genesys_api_key",
                AuthorizationMethod.Invalid => "invalid",
                AuthorizationMethod.LivekitToken => "livekit_token",
                AuthorizationMethod.LivekitTokenWebsite => "livekit_token_website",
                AuthorizationMethod.Public => "public",
                AuthorizationMethod.ShareableLink => "shareable_link",
                AuthorizationMethod.SignedUrl => "signed_url",
                AuthorizationMethod.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorizationMethod? ToEnum(string value)
        {
            return value switch
            {
                "authorization_header" => AuthorizationMethod.AuthorizationHeader,
                "genesys_api_key" => AuthorizationMethod.GenesysApiKey,
                "invalid" => AuthorizationMethod.Invalid,
                "livekit_token" => AuthorizationMethod.LivekitToken,
                "livekit_token_website" => AuthorizationMethod.LivekitTokenWebsite,
                "public" => AuthorizationMethod.Public,
                "shareable_link" => AuthorizationMethod.ShareableLink,
                "signed_url" => AuthorizationMethod.SignedUrl,
                "whatsapp" => AuthorizationMethod.Whatsapp,
                _ => null,
            };
        }
    }
}