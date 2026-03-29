//HintName: G.Models.TableCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableCreateRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The digests of the rows that were created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digests")]
        public global::System.Collections.Generic.IList<string>? RowDigests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateRes" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="rowDigests">
        /// The digests of the rows that were created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableCreateRes(
            string digest,
            global::System.Collections.Generic.IList<string>? rowDigests)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.RowDigests = rowDigests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateRes" /> class.
        /// </summary>
        public TableCreateRes()
        {
        }
    }
}