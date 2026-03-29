//HintName: G.Models.SparseIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for sparse inverted index.
    /// </summary>
    public sealed partial class SparseIndexConfig
    {
        /// <summary>
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_scan_threshold")]
        public int? FullScanThreshold { get; set; }

        /// <summary>
        /// Sparse index types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SparseIndexTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SparseIndexType IndexType { get; set; }

        /// <summary>
        /// Datatype used to store weights in the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatype")]
        public global::G.VectorStorageDatatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexConfig" /> class.
        /// </summary>
        /// <param name="indexType">
        /// Sparse index types
        /// </param>
        /// <param name="fullScanThreshold">
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </param>
        /// <param name="datatype">
        /// Datatype used to store weights in the index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseIndexConfig(
            global::G.SparseIndexType indexType,
            int? fullScanThreshold,
            global::G.VectorStorageDatatype? datatype)
        {
            this.FullScanThreshold = fullScanThreshold;
            this.IndexType = indexType;
            this.Datatype = datatype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexConfig" /> class.
        /// </summary>
        public SparseIndexConfig()
        {
        }
    }
}