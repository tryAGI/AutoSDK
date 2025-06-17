//HintName: G.Models.UpdateConnectorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConnectorRequest
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        public global::System.Collections.Generic.IList<string>? Excludes { get; set; }

        /// <summary>
        /// A human-readable name for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth")]
        public global::G.CreateConnectorOAuth? Oauth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_auth")]
        public global::G.CreateConnectorServiceAuth? ServiceAuth { get; set; }

        /// <summary>
        /// The URL of the connector that will be used to search for documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorRequest" /> class.
        /// </summary>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="continueOnFailure">
        /// Default Value: false
        /// </param>
        /// <param name="excludes">
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </param>
        /// <param name="name">
        /// A human-readable name for the connector.
        /// </param>
        /// <param name="oauth"></param>
        /// <param name="serviceAuth"></param>
        /// <param name="url">
        /// The URL of the connector that will be used to search for documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConnectorRequest(
            bool? active,
            bool? continueOnFailure,
            global::System.Collections.Generic.IList<string>? excludes,
            string? name,
            global::G.CreateConnectorOAuth? oauth,
            global::G.CreateConnectorServiceAuth? serviceAuth,
            string? url)
        {
            this.Active = active;
            this.ContinueOnFailure = continueOnFailure;
            this.Excludes = excludes;
            this.Name = name;
            this.Oauth = oauth;
            this.ServiceAuth = serviceAuth;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorRequest" /> class.
        /// </summary>
        public UpdateConnectorRequest()
        {
        }
    }
}