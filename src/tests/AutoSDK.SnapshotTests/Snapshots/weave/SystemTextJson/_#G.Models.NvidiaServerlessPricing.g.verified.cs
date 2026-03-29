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
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_million_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerMillionInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_million_output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerMillionOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaServerlessPricing" /> class.
        /// </summary>
        /// <param name="centsPerMillionInputTokens"></param>
        /// <param name="centsPerMillionOutputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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