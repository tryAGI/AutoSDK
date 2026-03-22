//HintName: G.Models.AuthProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-oidc")]
        CustomOidc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email")]
        Email,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oidc")]
        Oidc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="supabase:non-sso")]
        Supabase_nonSso,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="supabase:sso")]
        Supabase_sso,
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
                AuthProvider.CustomOidc => "custom-oidc",
                AuthProvider.Email => "email",
                AuthProvider.Oidc => "oidc",
                AuthProvider.Supabase_nonSso => "supabase:non-sso",
                AuthProvider.Supabase_sso => "supabase:sso",
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
                "custom-oidc" => AuthProvider.CustomOidc,
                "email" => AuthProvider.Email,
                "oidc" => AuthProvider.Oidc,
                "supabase:non-sso" => AuthProvider.Supabase_nonSso,
                "supabase:sso" => AuthProvider.Supabase_sso,
                _ => null,
            };
        }
    }
}