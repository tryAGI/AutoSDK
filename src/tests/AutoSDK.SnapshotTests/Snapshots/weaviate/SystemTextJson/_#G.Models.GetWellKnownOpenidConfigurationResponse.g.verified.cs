//HintName: G.Models.GetWellKnownOpenidConfigurationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWellKnownOpenidConfigurationResponse
    {
        /// <summary>
        /// The Location to redirect to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// OAuth Client ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// OAuth Scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWellKnownOpenidConfigurationResponse" /> class.
        /// </summary>
        /// <param name="href">
        /// The Location to redirect to
        /// </param>
        /// <param name="clientId">
        /// OAuth Client ID
        /// </param>
        /// <param name="scopes">
        /// OAuth Scopes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWellKnownOpenidConfigurationResponse(
            string? href,
            string? clientId,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Href = href;
            this.ClientId = clientId;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWellKnownOpenidConfigurationResponse" /> class.
        /// </summary>
        public GetWellKnownOpenidConfigurationResponse()
        {
        }
    }
}