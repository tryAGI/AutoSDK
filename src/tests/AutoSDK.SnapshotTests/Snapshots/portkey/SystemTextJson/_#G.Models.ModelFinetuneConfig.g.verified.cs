//HintName: G.Models.ModelFinetuneConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fine-tuning pricing configuration
    /// </summary>
    public sealed partial class ModelFinetuneConfig
    {
        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pay_per_token")]
        public global::G.ModelTokenPrice? PayPerToken { get; set; }

        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pay_per_hour")]
        public global::G.ModelTokenPrice? PayPerHour { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFinetuneConfig" /> class.
        /// </summary>
        /// <param name="payPerToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="payPerHour">
        /// Price object (value is in USD cents)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelFinetuneConfig(
            global::G.ModelTokenPrice? payPerToken,
            global::G.ModelTokenPrice? payPerHour)
        {
            this.PayPerToken = payPerToken;
            this.PayPerHour = payPerHour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFinetuneConfig" /> class.
        /// </summary>
        public ModelFinetuneConfig()
        {
        }
    }
}