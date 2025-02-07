//HintName: G.Models.ControlnetInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ControlnetInput
    {
        /// <summary>
        /// The ID of the init image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initImageId")]
        public string? InitImageId { get; set; }

        /// <summary>
        /// Type indicating whether the init image is uploaded or generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initImageType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ControlnetInputInitImageTypeJsonConverter))]
        public global::G.ControlnetInputInitImageType? InitImageType { get; set; }

        /// <summary>
        /// ID of the controlnet. A list of compatible IDs can be found in our guides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessorId")]
        public double? PreprocessorId { get; set; }

        /// <summary>
        /// Weight for the controlnet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Strength type for the controlnet. Can only be used for Style, Character and Content Reference controlnets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strengthType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ControlnetInputStrengthTypeJsonConverter))]
        public global::G.ControlnetInputStrengthType? StrengthType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlnetInput" /> class.
        /// </summary>
        /// <param name="initImageId">
        /// The ID of the init image
        /// </param>
        /// <param name="initImageType">
        /// Type indicating whether the init image is uploaded or generated.
        /// </param>
        /// <param name="preprocessorId">
        /// ID of the controlnet. A list of compatible IDs can be found in our guides.
        /// </param>
        /// <param name="weight">
        /// Weight for the controlnet
        /// </param>
        /// <param name="strengthType">
        /// Strength type for the controlnet. Can only be used for Style, Character and Content Reference controlnets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ControlnetInput(
            string? initImageId,
            global::G.ControlnetInputInitImageType? initImageType,
            double? preprocessorId,
            double? weight,
            global::G.ControlnetInputStrengthType? strengthType)
        {
            this.InitImageId = initImageId;
            this.InitImageType = initImageType;
            this.PreprocessorId = preprocessorId;
            this.Weight = weight;
            this.StrengthType = strengthType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlnetInput" /> class.
        /// </summary>
        public ControlnetInput()
        {
        }
    }
}