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
        [global::Newtonsoft.Json.JsonProperty("full_scan_threshold")]
        public int? FullScanThreshold { get; set; }

        /// <summary>
        /// Sparse index types
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SparseIndexType IndexType { get; set; } = default!;

        /// <summary>
        /// Datatype used to store weights in the index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datatype")]
        public global::G.VectorStorageDatatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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