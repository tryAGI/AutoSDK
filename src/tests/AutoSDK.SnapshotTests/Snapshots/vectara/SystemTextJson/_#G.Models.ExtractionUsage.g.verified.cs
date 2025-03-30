//HintName: G.Models.ExtractionUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much extraction quota the document used. This information is currently not returned when<br/>
    /// retrieving the document, and only returned when indexing a document.
    /// </summary>
    public sealed partial class ExtractionUsage
    {
        /// <summary>
        /// The number of pages from the document that consumed the extraction quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_extraction_used")]
        public long? TableExtractionUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionUsage" /> class.
        /// </summary>
        /// <param name="tableExtractionUsed">
        /// The number of pages from the document that consumed the extraction quota.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionUsage(
            long? tableExtractionUsed)
        {
            this.TableExtractionUsed = tableExtractionUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionUsage" /> class.
        /// </summary>
        public ExtractionUsage()
        {
        }
    }
}