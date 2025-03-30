//HintName: G.Models.ListTableExtractorsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of available table extractors for document processing
    /// </summary>
    public sealed partial class ListTableExtractorsResponse
    {
        /// <summary>
        /// An array of table extractors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_extractors")]
        public global::System.Collections.Generic.IList<global::G.TableExtractor>? TableExtractors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableExtractorsResponse" /> class.
        /// </summary>
        /// <param name="tableExtractors">
        /// An array of table extractors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTableExtractorsResponse(
            global::System.Collections.Generic.IList<global::G.TableExtractor>? tableExtractors)
        {
            this.TableExtractors = tableExtractors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableExtractorsResponse" /> class.
        /// </summary>
        public ListTableExtractorsResponse()
        {
        }
    }
}