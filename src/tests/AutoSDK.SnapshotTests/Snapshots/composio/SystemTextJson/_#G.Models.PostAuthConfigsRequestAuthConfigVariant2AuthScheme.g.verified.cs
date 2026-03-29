//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant2AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostAuthConfigsRequestAuthConfigVariant2AuthScheme
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
    public static class PostAuthConfigsRequestAuthConfigVariant2AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostAuthConfigsRequestAuthConfigVariant2AuthScheme value)
        {
            return value switch
            {
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.ApiKey => "API_KEY",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Basic => "BASIC",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.BearerToken => "BEARER_TOKEN",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.BillcomAuth => "BILLCOM_AUTH",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.CalcomAuth => "CALCOM_AUTH",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.DcrOauth => "DCR_OAUTH",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.NoAuth => "NO_AUTH",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Oauth1 => "OAUTH1",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Oauth2 => "OAUTH2",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.S2sOauth2 => "S2S_OAUTH2",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Saml => "SAML",
                PostAuthConfigsRequestAuthConfigVariant2AuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostAuthConfigsRequestAuthConfigVariant2AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.ApiKey,
                "BASIC" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Basic,
                "BASIC_WITH_JWT" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.BearerToken,
                "BILLCOM_AUTH" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.BillcomAuth,
                "CALCOM_AUTH" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.CalcomAuth,
                "DCR_OAUTH" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.GoogleServiceAccount,
                "NO_AUTH" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.NoAuth,
                "OAUTH1" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Oauth1,
                "OAUTH2" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Oauth2,
                "S2S_OAUTH2" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.S2sOauth2,
                "SAML" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.Saml,
                "SERVICE_ACCOUNT" => PostAuthConfigsRequestAuthConfigVariant2AuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}