//HintName: G.Models.TableRowFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableRowFilter
    {
        /// <summary>
        /// List of row digests to filter by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digests")]
        public global::System.Collections.Generic.IList<string>? RowDigests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowFilter" /> class.
        /// </summary>
        /// <param name="rowDigests">
        /// List of row digests to filter by
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableRowFilter(
            global::System.Collections.Generic.IList<string>? rowDigests)
        {
            this.RowDigests = rowDigests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowFilter" /> class.
        /// </summary>
        public TableRowFilter()
        {
        }
    }
}