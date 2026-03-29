//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant2AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostAuthConfigsRequestAuthConfigVariant2AuthScheme
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