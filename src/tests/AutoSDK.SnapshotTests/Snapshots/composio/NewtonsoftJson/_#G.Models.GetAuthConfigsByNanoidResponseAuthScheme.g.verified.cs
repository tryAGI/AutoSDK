//HintName: G.Models.GetAuthConfigsByNanoidResponseAuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication scheme used (e.g., OAuth2, API Key, etc.)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAuthConfigsByNanoidResponseAuthScheme
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
    public static class GetAuthConfigsByNanoidResponseAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthConfigsByNanoidResponseAuthScheme value)
        {
            return value switch
            {
                GetAuthConfigsByNanoidResponseAuthScheme.ApiKey => "API_KEY",
                GetAuthConfigsByNanoidResponseAuthScheme.Basic => "BASIC",
                GetAuthConfigsByNanoidResponseAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                GetAuthConfigsByNanoidResponseAuthScheme.BearerToken => "BEARER_TOKEN",
                GetAuthConfigsByNanoidResponseAuthScheme.BillcomAuth => "BILLCOM_AUTH",
                GetAuthConfigsByNanoidResponseAuthScheme.CalcomAuth => "CALCOM_AUTH",
                GetAuthConfigsByNanoidResponseAuthScheme.DcrOauth => "DCR_OAUTH",
                GetAuthConfigsByNanoidResponseAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                GetAuthConfigsByNanoidResponseAuthScheme.NoAuth => "NO_AUTH",
                GetAuthConfigsByNanoidResponseAuthScheme.Oauth1 => "OAUTH1",
                GetAuthConfigsByNanoidResponseAuthScheme.Oauth2 => "OAUTH2",
                GetAuthConfigsByNanoidResponseAuthScheme.S2sOauth2 => "S2S_OAUTH2",
                GetAuthConfigsByNanoidResponseAuthScheme.Saml => "SAML",
                GetAuthConfigsByNanoidResponseAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthConfigsByNanoidResponseAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetAuthConfigsByNanoidResponseAuthScheme.ApiKey,
                "BASIC" => GetAuthConfigsByNanoidResponseAuthScheme.Basic,
                "BASIC_WITH_JWT" => GetAuthConfigsByNanoidResponseAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => GetAuthConfigsByNanoidResponseAuthScheme.BearerToken,
                "BILLCOM_AUTH" => GetAuthConfigsByNanoidResponseAuthScheme.BillcomAuth,
                "CALCOM_AUTH" => GetAuthConfigsByNanoidResponseAuthScheme.CalcomAuth,
                "DCR_OAUTH" => GetAuthConfigsByNanoidResponseAuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => GetAuthConfigsByNanoidResponseAuthScheme.GoogleServiceAccount,
                "NO_AUTH" => GetAuthConfigsByNanoidResponseAuthScheme.NoAuth,
                "OAUTH1" => GetAuthConfigsByNanoidResponseAuthScheme.Oauth1,
                "OAUTH2" => GetAuthConfigsByNanoidResponseAuthScheme.Oauth2,
                "S2S_OAUTH2" => GetAuthConfigsByNanoidResponseAuthScheme.S2sOauth2,
                "SAML" => GetAuthConfigsByNanoidResponseAuthScheme.Saml,
                "SERVICE_ACCOUNT" => GetAuthConfigsByNanoidResponseAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}