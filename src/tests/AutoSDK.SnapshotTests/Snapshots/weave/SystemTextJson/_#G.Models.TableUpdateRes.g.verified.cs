//HintName: G.Models.TableUpdateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableUpdateRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The digests of the rows that were updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_row_digests")]
        public global::System.Collections.Generic.IList<string>? UpdatedRowDigests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdateRes" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="updatedRowDigests">
        /// The digests of the rows that were updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableUpdateRes(
            string digest,
            global::System.Collections.Generic.IList<string>? updatedRowDigests)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.UpdatedRowDigests = updatedRowDigests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdateRes" /> class.
        /// </summary>
        public TableUpdateRes()
        {
        }
    }
}