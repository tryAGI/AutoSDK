//HintName: G.Models.NvidiaServerlessPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NvidiaServerlessPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_million_input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerMillionInputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_million_output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerMillionOutputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaServerlessPricing" /> class.
        /// </summary>
        /// <param name="centsPerMillionInputTokens"></param>
        /// <param name="centsPerMillionOutputTokens"></param>
        public NvidiaServerlessPricing(
            double centsPerMillionInputTokens,
            double centsPerMillionOutputTokens)
        {
            this.CentsPerMillionInputTokens = centsPerMillionInputTokens;
            this.CentsPerMillionOutputTokens = centsPerMillionOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaServerlessPricing" /> class.
        /// </summary>
        public NvidiaServerlessPricing()
        {
        }
    }
}