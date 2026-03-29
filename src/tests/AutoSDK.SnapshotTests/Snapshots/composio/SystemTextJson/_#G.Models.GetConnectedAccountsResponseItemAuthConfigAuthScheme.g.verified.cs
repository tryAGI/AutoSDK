//HintName: G.Models.GetConnectedAccountsResponseItemAuthConfigAuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the authScheme is part of the connection state use it there
    /// </summary>
    public enum GetConnectedAccountsResponseItemAuthConfigAuthScheme
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
    public static class GetConnectedAccountsResponseItemAuthConfigAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemAuthConfigAuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.ApiKey => "API_KEY",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.Basic => "BASIC",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.BearerToken => "BEARER_TOKEN",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.BillcomAuth => "BILLCOM_AUTH",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.CalcomAuth => "CALCOM_AUTH",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.DcrOauth => "DCR_OAUTH",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.NoAuth => "NO_AUTH",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.Oauth1 => "OAUTH1",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.Oauth2 => "OAUTH2",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.S2sOauth2 => "S2S_OAUTH2",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.Saml => "SAML",
                GetConnectedAccountsResponseItemAuthConfigAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemAuthConfigAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.ApiKey,
                "BASIC" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.Basic,
                "BASIC_WITH_JWT" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.BearerToken,
                "BILLCOM_AUTH" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.BillcomAuth,
                "CALCOM_AUTH" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.CalcomAuth,
                "DCR_OAUTH" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.GoogleServiceAccount,
                "NO_AUTH" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.NoAuth,
                "OAUTH1" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.Oauth1,
                "OAUTH2" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.Oauth2,
                "S2S_OAUTH2" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.S2sOauth2,
                "SAML" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.Saml,
                "SERVICE_ACCOUNT" => GetConnectedAccountsResponseItemAuthConfigAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}