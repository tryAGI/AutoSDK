﻿//HintName: G.Models.AuthorizationMethod.g.cs

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
        [global::System.Runtime.Serialization.EnumMember(Value="invalid")]
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_header")]
        AuthorizationHeader,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signed_url")]
        SignedUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shareable_link")]
        ShareableLink,
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
        [global::System.Runtime.Serialization.EnumMember(Value="genesys_api_key")]
        GenesysApiKey,
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
                AuthorizationMethod.Invalid => "invalid",
                AuthorizationMethod.Public => "public",
                AuthorizationMethod.AuthorizationHeader => "authorization_header",
                AuthorizationMethod.SignedUrl => "signed_url",
                AuthorizationMethod.ShareableLink => "shareable_link",
                AuthorizationMethod.LivekitToken => "livekit_token",
                AuthorizationMethod.LivekitTokenWebsite => "livekit_token_website",
                AuthorizationMethod.GenesysApiKey => "genesys_api_key",
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
                "invalid" => AuthorizationMethod.Invalid,
                "public" => AuthorizationMethod.Public,
                "authorization_header" => AuthorizationMethod.AuthorizationHeader,
                "signed_url" => AuthorizationMethod.SignedUrl,
                "shareable_link" => AuthorizationMethod.ShareableLink,
                "livekit_token" => AuthorizationMethod.LivekitToken,
                "livekit_token_website" => AuthorizationMethod.LivekitTokenWebsite,
                "genesys_api_key" => AuthorizationMethod.GenesysApiKey,
                _ => null,
            };
        }
    }
}