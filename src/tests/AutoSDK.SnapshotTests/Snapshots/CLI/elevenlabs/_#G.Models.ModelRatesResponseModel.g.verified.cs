//HintName: G.Models.ModelRatesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRatesResponseModel
    {
        /// <summary>
        /// The cost multiplier for characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_cost_multiplier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CharacterCostMultiplier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRatesResponseModel" /> class.
        /// </summary>
        /// <param name="characterCostMultiplier">
        /// The cost multiplier for characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelRatesResponseModel(
            double characterCostMultiplier)
        {
            this.CharacterCostMultiplier = characterCostMultiplier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRatesResponseModel" /> class.
        /// </summary>
        public ModelRatesResponseModel()
        {
        }
    }
}