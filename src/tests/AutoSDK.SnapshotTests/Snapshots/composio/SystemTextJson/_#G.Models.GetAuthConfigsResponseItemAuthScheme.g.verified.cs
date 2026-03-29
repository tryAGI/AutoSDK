//HintName: G.Models.GetAuthConfigsResponseItemAuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication scheme used (e.g., OAuth2, API Key, etc.)
    /// </summary>
    public enum GetAuthConfigsResponseItemAuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        BasicWithJwt,
        /// <summary>
        /// 
        /// </summary>
        BearerToken,
        /// <summary>
        /// 
        /// </summary>
        BillcomAuth,
        /// <summary>
        /// 
        /// </summary>
        CalcomAuth,
        /// <summary>
        /// 
        /// </summary>
        DcrOauth,
        /// <summary>
        /// 
        /// </summary>
        GoogleServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        NoAuth,
        /// <summary>
        /// 
        /// </summary>
        Oauth1,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
        /// <summary>
        /// 
        /// </summary>
        S2sOauth2,
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
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