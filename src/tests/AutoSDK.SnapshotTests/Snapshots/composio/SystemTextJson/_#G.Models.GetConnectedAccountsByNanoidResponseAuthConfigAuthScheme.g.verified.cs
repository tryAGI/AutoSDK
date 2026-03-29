//HintName: G.Models.GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the authScheme is part of the connection state use it there
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme
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
    public static class GetConnectedAccountsByNanoidResponseAuthConfigAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.ApiKey => "API_KEY",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Basic => "BASIC",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.BearerToken => "BEARER_TOKEN",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.BillcomAuth => "BILLCOM_AUTH",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.CalcomAuth => "CALCOM_AUTH",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.DcrOauth => "DCR_OAUTH",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.NoAuth => "NO_AUTH",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Oauth1 => "OAUTH1",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Oauth2 => "OAUTH2",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.S2sOauth2 => "S2S_OAUTH2",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Saml => "SAML",
                GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.ApiKey,
                "BASIC" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Basic,
                "BASIC_WITH_JWT" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.BearerToken,
                "BILLCOM_AUTH" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.BillcomAuth,
                "CALCOM_AUTH" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.CalcomAuth,
                "DCR_OAUTH" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.GoogleServiceAccount,
                "NO_AUTH" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.NoAuth,
                "OAUTH1" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Oauth1,
                "OAUTH2" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Oauth2,
                "S2S_OAUTH2" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.S2sOauth2,
                "SAML" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.Saml,
                "SERVICE_ACCOUNT" => GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}