//HintName: G.Models.ModelSettingsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"stability":0.5}
    /// </summary>
    public sealed partial class ModelSettingsResponseModel
    {
        /// <summary>
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="stability">
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.<br/>
        /// Default Value: 0.5F
        /// </param>
        public ModelSettingsResponseModel(
            double? stability)
        {
            this.Stability = stability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsResponseModel" /> class.
        /// </summary>
        public ModelSettingsResponseModel()
        {
        }
    }
}