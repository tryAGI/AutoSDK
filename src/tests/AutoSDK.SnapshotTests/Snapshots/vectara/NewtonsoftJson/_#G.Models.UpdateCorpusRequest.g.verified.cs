//HintName: G.Models.UpdateCorpusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Corpus properties that are modifiable after creation.
    /// </summary>
    public sealed partial class UpdateCorpusRequest
    {
        /// <summary>
        /// Set whether or not the corpus is enabled. If unset then the corpus will remain in the same state.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The name for the corpus. If unset or null then the corpus will remain in the same state.<br/>
        /// Example: new-name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the corpus. If unset or null then the corpus will remain in the same state.<br/>
        /// Example: New description for the corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}