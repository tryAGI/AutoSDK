//HintName: G.Models.ModelPricingInputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputTokens
    {
        /// <summary>
        /// Default Value: input_tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_input_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerInputToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputTokens" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: input_tokens
        /// </param>
        /// <param name="centsPerInputToken"></param>
        public ModelPricingInputTokens(
            double centsPerInputToken,
            string? type)
        {
            this.CentsPerInputToken = centsPerInputToken;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputTokens" /> class.
        /// </summary>
        public ModelPricingInputTokens()
        {
        }
    }
}