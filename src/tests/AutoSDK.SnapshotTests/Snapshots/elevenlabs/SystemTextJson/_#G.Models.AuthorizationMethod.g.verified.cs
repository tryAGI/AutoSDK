//HintName: G.Models.AuthorizationMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthorizationMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        AuthorizationHeader,
        /// <summary>
        /// 
        /// </summary>
        SignedUrl,
        /// <summary>
        /// 
        /// </summary>
        ShareableLink,
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
                AuthorizationMethod.Public => "public",
                AuthorizationMethod.AuthorizationHeader => "authorization_header",
                AuthorizationMethod.SignedUrl => "signed_url",
                AuthorizationMethod.ShareableLink => "shareable_link",
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
                "public" => AuthorizationMethod.Public,
                "authorization_header" => AuthorizationMethod.AuthorizationHeader,
                "signed_url" => AuthorizationMethod.SignedUrl,
                "shareable_link" => AuthorizationMethod.ShareableLink,
                _ => null,
            };
        }
    }
}