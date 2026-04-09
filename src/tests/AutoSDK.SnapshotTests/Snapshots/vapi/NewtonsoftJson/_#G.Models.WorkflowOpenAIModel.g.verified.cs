//HintName: G.Models.WorkflowOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowOpenAIModel
    {
        /// <summary>
        /// This is the provider of the model (`openai`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowOpenAIModelProviderJsonConverter))]
        public global::G.WorkflowOpenAIModelProvider Provider { get; set; }

        /// <summary>
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowOpenAIModelModelJsonConverter))]
        public global::G.WorkflowOpenAIModelModel Model { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="WorkflowOpenAIModel" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </param>
        /// <param name="provider">
        /// This is the provider of the model (`openai`).
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.
        /// </param>
        public WorkflowOpenAIModel(
            global::G.WorkflowOpenAIModelModel model,
            global::G.WorkflowOpenAIModelProvider provider,
            double? temperature,
            double? maxTokens)
        {
            this.Provider = provider;
            this.Model = model;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOpenAIModel" /> class.
        /// </summary>
        public WorkflowOpenAIModel()
        {
        }
    }
}