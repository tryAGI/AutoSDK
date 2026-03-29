//HintName: G.Models.TableRowSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableRowSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Val { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_index")]
        public int? OriginalIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowSchema" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="val"></param>
        /// <param name="originalIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableRowSchema(
            string digest,
            object val,
            int? originalIndex)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
            this.OriginalIndex = originalIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowSchema" /> class.
        /// </summary>
        public TableRowSchema()
        {
        }
    }
}