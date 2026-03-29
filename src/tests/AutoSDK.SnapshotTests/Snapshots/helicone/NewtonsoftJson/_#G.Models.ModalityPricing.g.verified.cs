//HintName: G.Models.ModalityPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Per-modality pricing configuration.<br/>
    /// Supports input, cached input (as multiplier), and output rates.
    /// </summary>
    public sealed partial class ModalityPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public double? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cachedInputMultiplier")]
        public double? CachedInputMultiplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public double? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityPricing" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cachedInputMultiplier"></param>
        /// <param name="output"></param>
        public ModalityPricing(
            double? input,
            double? cachedInputMultiplier,
            double? output)
        {
            this.Input = input;
            this.CachedInputMultiplier = cachedInputMultiplier;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityPricing" /> class.
        /// </summary>
        public ModalityPricing()
        {
        }
    }
}