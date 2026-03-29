//HintName: G.Models.ReturnLanguageModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnLanguageModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_provider")]
        public string? ModelProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_resource")]
        public string? ModelResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnLanguageModel" /> class.
        /// </summary>
        /// <param name="modelProvider"></param>
        /// <param name="modelResource"></param>
        /// <param name="temperature"></param>
        public ReturnLanguageModel(
            string? modelProvider,
            string? modelResource,
            double? temperature)
        {
            this.ModelProvider = modelProvider;
            this.ModelResource = modelResource;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnLanguageModel" /> class.
        /// </summary>
        public ReturnLanguageModel()
        {
        }
    }
}