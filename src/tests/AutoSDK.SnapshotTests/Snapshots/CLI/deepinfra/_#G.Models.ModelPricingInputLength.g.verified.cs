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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        /// <param name="centsPerInputSec"></param>
        /// <param name="type">
        /// Default Value: input_length
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingInputLength(
            double centsPerInputSec,
            string? type)
        {
            this.Type = type;
            this.CentsPerInputSec = centsPerInputSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        public ModelPricingInputLength()
        {
        }
    }
}