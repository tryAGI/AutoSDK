//HintName: G.Models.PostConnectedAccountsByNanoidRefreshResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response schema for a refreshed connected account authentication<br/>
    /// Example: {"id":"con_1a2b3c4d5e6f","status":"ACTIVE","redirect_url":"https://app.example.com/oauth/callback"}
    /// </summary>
    public sealed partial class PostConnectedAccountsByNanoidRefreshResponse
    {
        /// <summary>
        /// The unique identifier of the connected account
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The current status of the connected account (e.g., active, pending, failed)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostConnectedAccountsByNanoidRefreshResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// The URL to which the user should be redirected to complete the authentication process (null for auth schemes that do not require redirection)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsByNanoidRefreshResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the connected account
        /// </param>
        /// <param name="status">
        /// The current status of the connected account (e.g., active, pending, failed)
        /// </param>
        /// <param name="redirectUrl">
        /// The URL to which the user should be redirected to complete the authentication process (null for auth schemes that do not require redirection)
        /// </param>
        public PostConnectedAccountsByNanoidRefreshResponse(
            string id,
            global::G.PostConnectedAccountsByNanoidRefreshResponseStatus status,
            string? redirectUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsByNanoidRefreshResponse" /> class.
        /// </summary>
        public PostConnectedAccountsByNanoidRefreshResponse()
        {
        }
    }
}