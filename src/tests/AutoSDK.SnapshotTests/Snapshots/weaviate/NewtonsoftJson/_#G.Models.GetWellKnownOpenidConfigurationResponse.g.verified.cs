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
        [global::Newtonsoft.Json.JsonProperty("href")]
        public string? Href { get; set; }

        /// <summary>
        /// OAuth Client ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// OAuth Scopes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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