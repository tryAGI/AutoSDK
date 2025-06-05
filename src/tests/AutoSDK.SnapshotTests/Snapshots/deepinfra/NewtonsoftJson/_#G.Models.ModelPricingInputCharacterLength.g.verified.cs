//HintName: G.Models.ModelPricingInputCharacterLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputCharacterLength
    {
        /// <summary>
        /// Default Value: input_character_length
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cents_per_input_chars", Required = global::Newtonsoft.Json.Required.Always)]
        public double CentsPerInputChars { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputCharacterLength" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: input_character_length
        /// </param>
        /// <param name="centsPerInputChars"></param>
        public ModelPricingInputCharacterLength(
            double centsPerInputChars,
            string? type)
        {
            this.CentsPerInputChars = centsPerInputChars;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputCharacterLength" /> class.
        /// </summary>
        public ModelPricingInputCharacterLength()
        {
        }
    }
}