//HintName: G.Models.SparseVectorDataConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config of single sparse vector data storage
    /// </summary>
    public sealed partial class SparseVectorDataConfig
    {
        /// <summary>
        /// Configuration for sparse inverted index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SparseIndexConfig Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SparseVectorStorageTypeJsonConverter))]
        public global::G.SparseVectorStorageType? StorageType { get; set; }

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
        /// Initializes a new instance of the <see cref="SparseVectorDataConfig" /> class.
        /// </summary>
        /// <param name="index">
        /// Configuration for sparse inverted index.
        /// </param>
        /// <param name="storageType"></param>
        /// <param name="modifier">
        /// Configures addition value modifications for sparse vectors. Default: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVectorDataConfig(
            global::G.SparseIndexConfig index,
            global::G.SparseVectorStorageType? storageType,
            global::G.Modifier? modifier)
        {
            this.Index = index ?? throw new global::System.ArgumentNullException(nameof(index));
            this.StorageType = storageType;
            this.Modifier = modifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorDataConfig" /> class.
        /// </summary>
        public SparseVectorDataConfig()
        {
        }
    }
}