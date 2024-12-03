//HintName: G.Models.AuthProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Supabase_nonSso,
        /// <summary>
        /// 
        /// </summary>
        Supabase_sso,
        /// <summary>
        /// 
        /// </summary>
        Oidc,
        /// <summary>
        /// 
        /// </summary>
        CustomOidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthProvider value)
        {
            return value switch
            {
                AuthProvider.Email => "email",
                AuthProvider.Supabase_nonSso => "supabase:non-sso",
                AuthProvider.Supabase_sso => "supabase:sso",
                AuthProvider.Oidc => "oidc",
                AuthProvider.CustomOidc => "custom-oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthProvider? ToEnum(string value)
        {
            return value switch
            {
                "email" => AuthProvider.Email,
                "supabase:non-sso" => AuthProvider.Supabase_nonSso,
                "supabase:sso" => AuthProvider.Supabase_sso,
                "oidc" => AuthProvider.Oidc,
                "custom-oidc" => AuthProvider.CustomOidc,
                _ => null,
            };
        }
    }
}