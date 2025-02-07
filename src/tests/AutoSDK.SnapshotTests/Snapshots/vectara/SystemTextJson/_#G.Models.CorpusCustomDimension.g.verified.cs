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
        /// <example>importance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the custom dimension.<br/>
        /// Example: Product importance.
        /// </summary>
        /// <example>Product importance.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default value of a custom dimension on a document part if the custom<br/>
        /// dimension value is not specified when the document part is indexed.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_default")]
        public double? IndexingDefault { get; set; }

        /// <summary>
        /// Default value of a custom dimension for a query if the value<br/>
        /// of the custom dimension is not specified when querying the corpus.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("querying_default")]
        public double? QueryingDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusCustomDimension" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the custom dimension.<br/>
        /// Example: importance
        /// </param>
        /// <param name="description">
        /// Description of the custom dimension.<br/>
        /// Example: Product importance.
        /// </param>
        /// <param name="indexingDefault">
        /// Default value of a custom dimension on a document part if the custom<br/>
        /// dimension value is not specified when the document part is indexed.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="queryingDefault">
        /// Default value of a custom dimension for a query if the value<br/>
        /// of the custom dimension is not specified when querying the corpus.<br/>
        /// A value of 0 means that custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorpusCustomDimension(
            string name,
            string? description,
            double? indexingDefault,
            double? queryingDefault)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IndexingDefault = indexingDefault;
            this.QueryingDefault = queryingDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusCustomDimension" /> class.
        /// </summary>
        public CorpusCustomDimension()
        {
        }
    }
}