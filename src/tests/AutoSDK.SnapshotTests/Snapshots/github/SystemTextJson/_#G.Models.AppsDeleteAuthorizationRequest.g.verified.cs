//HintName: G.Models.AppsDeleteAuthorizationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsDeleteAuthorizationRequest
    {
        /// <summary>
        /// The OAuth access token used to authenticate to the GitHub API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsDeleteAuthorizationRequest" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The OAuth access token used to authenticate to the GitHub API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppsDeleteAuthorizationRequest(
            string accessToken)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsDeleteAuthorizationRequest" /> class.
        /// </summary>
        public AppsDeleteAuthorizationRequest()
        {
        }
    }
}