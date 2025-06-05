//HintName: G.Models.ModelPricingTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingTokens
    {
        /// <summary>
        /// Default Value: tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_input_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerInputToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_output_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerOutputToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTokens" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tokens
        /// </param>
        /// <param name="centsPerInputToken"></param>
        /// <param name="centsPerOutputToken"></param>
        public ModelPricingTokens(
            double centsPerInputToken,
            double centsPerOutputToken,
            string? type)
        {
            this.CentsPerInputToken = centsPerInputToken;
            this.CentsPerOutputToken = centsPerOutputToken;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTokens" /> class.
        /// </summary>
        public ModelPricingTokens()
        {
        }
    }
}