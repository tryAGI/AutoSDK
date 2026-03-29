//HintName: G.Models.SparseVectorParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Params of single sparse vector data storage
    /// </summary>
    public sealed partial class SparseVectorParams
    {
        /// <summary>
        /// Custom params for index. If none - values from collection configuration are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public global::G.SparseIndexParams? Index { get; set; }

        /// <summary>
        /// Configures addition value modifications for sparse vectors. Default: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifier")]
        public global::G.Modifier? Modifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorParams" /> class.
        /// </summary>
        /// <param name="index">
        /// Custom params for index. If none - values from collection configuration are used.
        /// </param>
        /// <param name="modifier">
        /// Configures addition value modifications for sparse vectors. Default: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVectorParams(
            global::G.SparseIndexParams? index,
            global::G.Modifier? modifier)
        {
            this.Index = index;
            this.Modifier = modifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorParams" /> class.
        /// </summary>
        public SparseVectorParams()
        {
        }
    }
}