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
        public bool Active { get; set; } = true;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("continue_on_failure")]
        public bool ContinueOnFailure { get; set; } = false;

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
    }
}