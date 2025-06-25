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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_output_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerOutputToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTokens" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tokens
        /// </param>
        /// <param name="centsPerInputToken"></param>
        /// <param name="centsPerOutputToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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