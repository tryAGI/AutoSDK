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
        /// A human-readable name for the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the connector that will be used to search for documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excludes")]
        public global::System.Collections.Generic.IList<string>? Excludes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oauth")]
        public global::G.CreateConnectorOAuth? Oauth { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_auth")]
        public global::G.CreateConnectorServiceAuth? ServiceAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A human-readable name for the connector.
        /// </param>
        /// <param name="url">
        /// The URL of the connector that will be used to search for documents.
        /// </param>
        /// <param name="excludes">
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </param>
        /// <param name="oauth"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="continueOnFailure">
        /// Default Value: false
        /// </param>
        /// <param name="serviceAuth"></param>
        public UpdateConnectorRequest(
            string? name,
            string? url,
            global::System.Collections.Generic.IList<string>? excludes,
            global::G.CreateConnectorOAuth? oauth,
            bool? active,
            bool? continueOnFailure,
            global::G.CreateConnectorServiceAuth? serviceAuth)
        {
            this.Name = name;
            this.Url = url;
            this.Excludes = excludes;
            this.Oauth = oauth;
            this.Active = active;
            this.ContinueOnFailure = continueOnFailure;
            this.ServiceAuth = serviceAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorRequest" /> class.
        /// </summary>
        public UpdateConnectorRequest()
        {
        }
    }
}