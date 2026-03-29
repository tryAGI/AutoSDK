//HintName: G.Models.BinaryQuantizationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BinaryQuantizationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always_ram")]
        public bool? AlwaysRam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        public global::G.BinaryQuantizationEncoding? Encoding { get; set; }

        /// <summary>
        /// Asymmetric quantization configuration allows a query to have different quantization than stored vectors. It can increase the accuracy of search at the cost of performance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_encoding")]
        public global::G.BinaryQuantizationQueryEncoding? QueryEncoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantizationConfig" /> class.
        /// </summary>
        /// <param name="alwaysRam"></param>
        /// <param name="encoding"></param>
        /// <param name="queryEncoding">
        /// Asymmetric quantization configuration allows a query to have different quantization than stored vectors. It can increase the accuracy of search at the cost of performance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BinaryQuantizationConfig(
            bool? alwaysRam,
            global::G.BinaryQuantizationEncoding? encoding,
            global::G.BinaryQuantizationQueryEncoding? queryEncoding)
        {
            this.AlwaysRam = alwaysRam;
            this.Encoding = encoding;
            this.QueryEncoding = queryEncoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantizationConfig" /> class.
        /// </summary>
        public BinaryQuantizationConfig()
        {
        }
    }
}