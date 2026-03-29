//HintName: G.Models.SparseIndexParamsDatatype.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines which datatype should be used for the index. Choosing different datatypes allows to optimize memory usage and performance vs accuracy.<br/>
    /// - For `float32` datatype - vectors are stored as single-precision floating point numbers, 4 bytes. - For `float16` datatype - vectors are stored as half-precision floating point numbers, 2 bytes. - For `uint8` datatype - vectors are quantized to unsigned 8-bit integers, 1 byte. Quantization to fit byte range `[0, 255]` happens during indexing automatically, so the actual vector data does not need to conform to this range.
    /// </summary>
    public sealed partial class SparseIndexParamsDatatype
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}