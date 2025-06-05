//HintName: G.Models.ModelPricingInputLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputLength
    {
        /// <summary>
        /// Default Value: input_length
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_input_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerInputSec { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: input_length
        /// </param>
        /// <param name="centsPerInputSec"></param>
        public ModelPricingInputLength(
            double centsPerInputSec,
            string? type)
        {
            this.CentsPerInputSec = centsPerInputSec;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        public ModelPricingInputLength()
        {
        }
    }
}