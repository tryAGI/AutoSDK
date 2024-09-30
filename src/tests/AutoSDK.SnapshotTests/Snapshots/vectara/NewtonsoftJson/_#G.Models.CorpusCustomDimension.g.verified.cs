//HintName: G.Models.CorpusCustomDimension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom dimensions attached to all document parts in a corpus. Allows arbitrary<br/>
    /// modification of the score for many purposes.
    /// </summary>
    public sealed partial class CorpusCustomDimension
    {
        /// <summary>
        /// The name of the custom dimension.<br/>
        /// Example: importance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default value of a custom dimension on a document part if the custom<br/>
        /// dimension value is not specified when the document part is indexed.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexing_default")]
        public double? IndexingDefault { get; set; } = 0;

        /// <summary>
        /// Default value of a custom dimension for a query if the value<br/>
        /// of the custom dimension is not specified when querying the corpus.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("querying_default")]
        public double? QueryingDefault { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}