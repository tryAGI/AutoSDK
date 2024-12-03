//HintName: G.Models.AppsResetTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsResetTokenRequest
    {
        /// <summary>
        /// The access_token of the OAuth or GitHub application.
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
        /// Initializes a new instance of the <see cref="AppsResetTokenRequest" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The access_token of the OAuth or GitHub application.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppsResetTokenRequest(
            string accessToken)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsResetTokenRequest" /> class.
        /// </summary>
        public AppsResetTokenRequest()
        {
        }
    }
}