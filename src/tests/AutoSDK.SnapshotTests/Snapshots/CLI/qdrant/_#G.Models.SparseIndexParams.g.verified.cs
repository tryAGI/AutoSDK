//HintName: G.Models.SparseIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for sparse inverted index.
    /// </summary>
    public sealed partial class SparseIndexParams
    {
        /// <summary>
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_scan_threshold")]
        public int? FullScanThreshold { get; set; }

        /// <summary>
        /// Store index on disk. If set to false, the index will be stored in RAM. Default: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Defines which datatype should be used for the index. Choosing different datatypes allows to optimize memory usage and performance vs accuracy.<br/>
        /// - For `float32` datatype - vectors are stored as single-precision floating point numbers, 4 bytes. - For `float16` datatype - vectors are stored as half-precision floating point numbers, 2 bytes. - For `uint8` datatype - vectors are quantized to unsigned 8-bit integers, 1 byte. Quantization to fit byte range `[0, 255]` happens during indexing automatically, so the actual vector data does not need to conform to this range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatype")]
        public global::G.Datatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexParams" /> class.
        /// </summary>
        /// <param name="fullScanThreshold">
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </param>
        /// <param name="onDisk">
        /// Store index on disk. If set to false, the index will be stored in RAM. Default: false
        /// </param>
        /// <param name="datatype">
        /// Defines which datatype should be used for the index. Choosing different datatypes allows to optimize memory usage and performance vs accuracy.<br/>
        /// - For `float32` datatype - vectors are stored as single-precision floating point numbers, 4 bytes. - For `float16` datatype - vectors are stored as half-precision floating point numbers, 2 bytes. - For `uint8` datatype - vectors are quantized to unsigned 8-bit integers, 1 byte. Quantization to fit byte range `[0, 255]` happens during indexing automatically, so the actual vector data does not need to conform to this range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseIndexParams(
            int? fullScanThreshold,
            bool? onDisk,
            global::G.Datatype? datatype)
        {
            this.FullScanThreshold = fullScanThreshold;
            this.OnDisk = onDisk;
            this.Datatype = datatype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexParams" /> class.
        /// </summary>
        public SparseIndexParams()
        {
        }
    }
}