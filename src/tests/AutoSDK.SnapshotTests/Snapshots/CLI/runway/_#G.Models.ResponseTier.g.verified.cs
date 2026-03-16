//HintName: G.Models.ResponseTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limits associated with the organization's tier.
    /// </summary>
    public sealed partial class ResponseTier
    {
        /// <summary>
        /// The maximum number of credits that can be purchased in a month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyCreditSpend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxMonthlyCreditSpend { get; set; }

        /// <summary>
        /// An object containing model-specific limits. Each key represents a model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.ResponseTierModels2> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTier" /> class.
        /// </summary>
        /// <param name="maxMonthlyCreditSpend">
        /// The maximum number of credits that can be purchased in a month.
        /// </param>
        /// <param name="models">
        /// An object containing model-specific limits. Each key represents a model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTier(
            int maxMonthlyCreditSpend,
            global::System.Collections.Generic.Dictionary<string, global::G.ResponseTierModels2> models)
        {
            this.MaxMonthlyCreditSpend = maxMonthlyCreditSpend;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTier" /> class.
        /// </summary>
        public ResponseTier()
        {
        }
    }
}