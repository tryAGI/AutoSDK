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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the custom dimension.<br/>
        /// Example: Product importance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default value of a custom dimension on a document part if the custom<br/>
        /// dimension value is not specified when the document part is indexed.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_default")]
        public double? IndexingDefault { get; set; } = 0;

        /// <summary>
        /// Default value of a custom dimension for a query if the value<br/>
        /// of the custom dimension is not specified when querying the corpus.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("querying_default")]
        public double? QueryingDefault { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}