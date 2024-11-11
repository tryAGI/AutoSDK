//HintName: G.Models.OAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OAuthConfig contains the configuration parameters for fetching an access<br/>
    /// token via an OAuth 2.0 flow.
    /// </summary>
    public sealed partial class OAuthConfig
    {
        /// <summary>
        /// The URL of the OAuth server to initiate the authentication and<br/>
        /// authorization process.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authUrl")]
        public string? AuthUrl { get; set; }

        /// <summary>
        /// The URL of the OAuth server to exchange the authorization code for an<br/>
        /// access token.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessUrl")]
        public string? AccessUrl { get; set; }

        /// <summary>
        /// A list of scopes that identify the resources that the connection will be<br/>
        /// able to access on the user's behalf.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfig" /> class.
        /// </summary>
        /// <param name="authUrl">
        /// The URL of the OAuth server to initiate the authentication and<br/>
        /// authorization process.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="accessUrl">
        /// The URL of the OAuth server to exchange the authorization code for an<br/>
        /// access token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="scopes">
        /// A list of scopes that identify the resources that the connection will be<br/>
        /// able to access on the user's behalf.<br/>
        /// Included only in responses
        /// </param>
        public OAuthConfig(
            string? authUrl,
            string? accessUrl,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.AuthUrl = authUrl;
            this.AccessUrl = accessUrl;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfig" /> class.
        /// </summary>
        public OAuthConfig()
        {
        }
    }
}