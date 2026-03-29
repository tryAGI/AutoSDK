//HintName: G.Models.GetAuthConfigsResponseItemAuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication scheme used (e.g., OAuth2, API Key, etc.)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAuthConfigsResponseItemAuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="API_KEY")]
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASIC")]
        Basic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASIC_WITH_JWT")]
        BasicWithJwt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEARER_TOKEN")]
        BearerToken,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BILLCOM_AUTH")]
        BillcomAuth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CALCOM_AUTH")]
        CalcomAuth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DCR_OAUTH")]
        DcrOauth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE_SERVICE_ACCOUNT")]
        GoogleServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NO_AUTH")]
        NoAuth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OAUTH1")]
        Oauth1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OAUTH2")]
        Oauth2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="S2S_OAUTH2")]
        S2sOauth2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SAML")]
        Saml,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SERVICE_ACCOUNT")]
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAuthConfigsResponseItemAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthConfigsResponseItemAuthScheme value)
        {
            return value switch
            {
                GetAuthConfigsResponseItemAuthScheme.ApiKey => "API_KEY",
                GetAuthConfigsResponseItemAuthScheme.Basic => "BASIC",
                GetAuthConfigsResponseItemAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                GetAuthConfigsResponseItemAuthScheme.BearerToken => "BEARER_TOKEN",
                GetAuthConfigsResponseItemAuthScheme.BillcomAuth => "BILLCOM_AUTH",
                GetAuthConfigsResponseItemAuthScheme.CalcomAuth => "CALCOM_AUTH",
                GetAuthConfigsResponseItemAuthScheme.DcrOauth => "DCR_OAUTH",
                GetAuthConfigsResponseItemAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                GetAuthConfigsResponseItemAuthScheme.NoAuth => "NO_AUTH",
                GetAuthConfigsResponseItemAuthScheme.Oauth1 => "OAUTH1",
                GetAuthConfigsResponseItemAuthScheme.Oauth2 => "OAUTH2",
                GetAuthConfigsResponseItemAuthScheme.S2sOauth2 => "S2S_OAUTH2",
                GetAuthConfigsResponseItemAuthScheme.Saml => "SAML",
                GetAuthConfigsResponseItemAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthConfigsResponseItemAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetAuthConfigsResponseItemAuthScheme.ApiKey,
                "BASIC" => GetAuthConfigsResponseItemAuthScheme.Basic,
                "BASIC_WITH_JWT" => GetAuthConfigsResponseItemAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => GetAuthConfigsResponseItemAuthScheme.BearerToken,
                "BILLCOM_AUTH" => GetAuthConfigsResponseItemAuthScheme.BillcomAuth,
                "CALCOM_AUTH" => GetAuthConfigsResponseItemAuthScheme.CalcomAuth,
                "DCR_OAUTH" => GetAuthConfigsResponseItemAuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => GetAuthConfigsResponseItemAuthScheme.GoogleServiceAccount,
                "NO_AUTH" => GetAuthConfigsResponseItemAuthScheme.NoAuth,
                "OAUTH1" => GetAuthConfigsResponseItemAuthScheme.Oauth1,
                "OAUTH2" => GetAuthConfigsResponseItemAuthScheme.Oauth2,
                "S2S_OAUTH2" => GetAuthConfigsResponseItemAuthScheme.S2sOauth2,
                "SAML" => GetAuthConfigsResponseItemAuthScheme.Saml,
                "SERVICE_ACCOUNT" => GetAuthConfigsResponseItemAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}