//HintName: G.Models.SplitCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a document split job.<br/>
    /// Provide configuration_id, inline configuration, or both. When both are<br/>
    /// provided, inline fields override the saved configuration.
    /// </summary>
    public sealed partial class SplitCreateRequest
    {
        /// <summary>
        /// Document to be split.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SplitDocumentInput DocumentInput { get; set; } = default!;

        /// <summary>
        /// Inline split configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.SplitConfiguration? Configuration { get; set; }

        /// <summary>
        /// Saved split configuration ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitCreateRequest" /> class.
        /// </summary>
        /// <param name="documentInput">
        /// Document to be split.
        /// </param>
        /// <param name="configuration">
        /// Inline split configuration.
        /// </param>
        /// <param name="configurationId">
        /// Saved split configuration ID.
        /// </param>
        public SplitCreateRequest(
            global::G.SplitDocumentInput documentInput,
            global::G.SplitConfiguration? configuration,
            string? configurationId)
        {
            this.DocumentInput = documentInput ?? throw new global::System.ArgumentNullException(nameof(documentInput));
            this.Configuration = configuration;
            this.ConfigurationId = configurationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitCreateRequest" /> class.
        /// </summary>
        public SplitCreateRequest()
        {
        }
    }
}