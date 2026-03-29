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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The current status of the connected account (e.g., active, pending, failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsByNanoidRefreshResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostConnectedAccountsByNanoidRefreshResponseStatus Status { get; set; }

        /// <summary>
        /// The URL to which the user should be redirected to complete the authentication process (null for auth schemes that do not require redirection)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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