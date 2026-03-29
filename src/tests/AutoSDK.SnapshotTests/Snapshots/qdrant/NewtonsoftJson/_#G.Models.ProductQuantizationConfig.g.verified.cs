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
        [global::Newtonsoft.Json.JsonProperty("compression", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompressionRatio Compression { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("always_ram")]
        public bool? AlwaysRam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantizationConfig" /> class.
        /// </summary>
        /// <param name="compression"></param>
        /// <param name="alwaysRam"></param>
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