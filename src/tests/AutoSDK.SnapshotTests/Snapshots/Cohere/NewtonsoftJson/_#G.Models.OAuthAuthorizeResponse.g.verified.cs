//HintName: G.Models.OAuthAuthorizeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuthAuthorizeResponse
    {
        /// <summary>
        /// The OAuth 2.0 redirect url. Redirect the user to this url to authorize the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}