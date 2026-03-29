//HintName: G.Models.ProductQuantizationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductQuantizationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompressionRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CompressionRatio Compression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always_ram")]
        public bool? AlwaysRam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantizationConfig" /> class.
        /// </summary>
        /// <param name="compression"></param>
        /// <param name="alwaysRam"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductQuantizationConfig(
            global::G.CompressionRatio compression,
            bool? alwaysRam)
        {
            this.Compression = compression;
            this.AlwaysRam = alwaysRam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantizationConfig" /> class.
        /// </summary>
        public ProductQuantizationConfig()
        {
        }
    }
}