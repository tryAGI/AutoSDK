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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_cost_multiplier", Required = global::Newtonsoft.Json.Required.Always)]
        public double CharacterCostMultiplier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRatesResponseModel" /> class.
        /// </summary>
        /// <param name="characterCostMultiplier"></param>
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