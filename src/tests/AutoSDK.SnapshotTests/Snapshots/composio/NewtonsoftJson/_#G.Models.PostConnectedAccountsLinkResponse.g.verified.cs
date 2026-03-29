//HintName: G.Models.PostConnectedAccountsLinkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsLinkResponse
    {
        /// <summary>
        /// The generated link token for the auth session
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("link_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string LinkToken { get; set; } = default!;

        /// <summary>
        /// The redirect URI to send users to for authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirect_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RedirectUrl { get; set; } = default!;

        /// <summary>
        /// ISO timestamp when the link expires
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The connected account ID that was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_account_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectedAccountId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkResponse" /> class.
        /// </summary>
        /// <param name="linkToken">
        /// The generated link token for the auth session
        /// </param>
        /// <param name="redirectUrl">
        /// The redirect URI to send users to for authentication
        /// </param>
        /// <param name="expiresAt">
        /// ISO timestamp when the link expires
        /// </param>
        /// <param name="connectedAccountId">
        /// The connected account ID that was created
        /// </param>
        public PostConnectedAccountsLinkResponse(
            string linkToken,
            string redirectUrl,
            string expiresAt,
            string connectedAccountId)
        {
            this.LinkToken = linkToken ?? throw new global::System.ArgumentNullException(nameof(linkToken));
            this.RedirectUrl = redirectUrl ?? throw new global::System.ArgumentNullException(nameof(redirectUrl));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.ConnectedAccountId = connectedAccountId ?? throw new global::System.ArgumentNullException(nameof(connectedAccountId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkResponse" /> class.
        /// </summary>
        public PostConnectedAccountsLinkResponse()
        {
        }
    }
}