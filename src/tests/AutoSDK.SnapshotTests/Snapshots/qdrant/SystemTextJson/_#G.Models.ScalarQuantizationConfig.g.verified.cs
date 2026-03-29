//HintName: G.Models.ScalarQuantizationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScalarQuantizationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScalarTypeJsonConverter))]
        public global::G.ScalarType Type { get; set; }

        /// <summary>
        /// Quantile for quantization. Expected value range in [0.5, 1.0]. If not set - use the whole range of values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantile")]
        public float? Quantile { get; set; }

        /// <summary>
        /// If true - quantized vectors always will be stored in RAM, ignoring the config of main storage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always_ram")]
        public bool? AlwaysRam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantizationConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="quantile">
        /// Quantile for quantization. Expected value range in [0.5, 1.0]. If not set - use the whole range of values
        /// </param>
        /// <param name="alwaysRam">
        /// If true - quantized vectors always will be stored in RAM, ignoring the config of main storage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalarQuantizationConfig(
            global::G.ScalarType type,
            float? quantile,
            bool? alwaysRam)
        {
            this.Type = type;
            this.Quantile = quantile;
            this.AlwaysRam = alwaysRam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantizationConfig" /> class.
        /// </summary>
        public ScalarQuantizationConfig()
        {
        }
    }
}