//HintName: G.Models.PostToolRouterSessionBySessionIdLinkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdLinkResponse
    {
        /// <summary>
        /// Token used to complete the authentication flow<br/>
        /// Example: lt_abc123xyz
        /// </summary>
        /// <example>lt_abc123xyz</example>
        [global::Newtonsoft.Json.JsonProperty("link_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string LinkToken { get; set; } = default!;

        /// <summary>
        /// The URL where users should be redirected to complete OAuth<br/>
        /// Example: https://app.composio.dev/link/lt_abc123xyz
        /// </summary>
        /// <example>https://app.composio.dev/link/lt_abc123xyz</example>
        [global::Newtonsoft.Json.JsonProperty("redirect_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RedirectUrl { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the connected account<br/>
        /// Example: ca_abc123xyz
        /// </summary>
        /// <example>ca_abc123xyz</example>
        [global::Newtonsoft.Json.JsonProperty("connected_account_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectedAccountId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkResponse" /> class.
        /// </summary>
        /// <param name="linkToken">
        /// Token used to complete the authentication flow<br/>
        /// Example: lt_abc123xyz
        /// </param>
        /// <param name="redirectUrl">
        /// The URL where users should be redirected to complete OAuth<br/>
        /// Example: https://app.composio.dev/link/lt_abc123xyz
        /// </param>
        /// <param name="connectedAccountId">
        /// The unique identifier for the connected account<br/>
        /// Example: ca_abc123xyz
        /// </param>
        public PostToolRouterSessionBySessionIdLinkResponse(
            string linkToken,
            string redirectUrl,
            string connectedAccountId)
        {
            this.LinkToken = linkToken ?? throw new global::System.ArgumentNullException(nameof(linkToken));
            this.RedirectUrl = redirectUrl ?? throw new global::System.ArgumentNullException(nameof(redirectUrl));
            this.ConnectedAccountId = connectedAccountId ?? throw new global::System.ArgumentNullException(nameof(connectedAccountId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkResponse" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdLinkResponse()
        {
        }
    }
}