//HintName: G.Models.WorkflowGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowGoogleModel
    {
        /// <summary>
        /// This is the provider of the model (`google`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowGoogleModelProviderJsonConverter))]
        public global::G.WorkflowGoogleModelProvider Provider { get; set; }

        /// <summary>
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowGoogleModelModelJsonConverter))]
        public global::G.WorkflowGoogleModelModel Model { get; set; } = default!;

        /// <summary>
        /// This is the temperature of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowGoogleModel" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </param>
        /// <param name="provider">
        /// This is the provider of the model (`google`).
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.
        /// </param>
        public WorkflowGoogleModel(
            global::G.WorkflowGoogleModelModel model,
            global::G.WorkflowGoogleModelProvider provider,
            double? temperature,
            double? maxTokens)
        {
            this.Provider = provider;
            this.Model = model;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowGoogleModel" /> class.
        /// </summary>
        public WorkflowGoogleModel()
        {
        }
    }
}