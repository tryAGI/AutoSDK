//HintName: G.Models.PricingCalculatorRequestServiceParamsMODELTRAINING.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for MODEL_TRAINING service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsMODELTRAINING
    {
        /// <summary>
        /// The resolution for training. Must be 512 or 768.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMODELTRAINING" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution for training. Must be 512 or 768.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParamsMODELTRAINING(
            int? resolution)
        {
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMODELTRAINING" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsMODELTRAINING()
        {
        }
    }
}