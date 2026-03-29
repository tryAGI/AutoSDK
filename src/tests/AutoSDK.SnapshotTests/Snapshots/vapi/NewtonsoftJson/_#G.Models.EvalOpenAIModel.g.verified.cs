//HintName: G.Models.EvalOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalOpenAIModel
    {
        /// <summary>
        /// This is the provider of the model (`openai`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.EvalOpenAIModelProvider Provider { get; set; }

        /// <summary>
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalOpenAIModelModel Model { get; set; } = default!;

        /// <summary>
        /// This is the temperature of the model. For LLM-as-a-judge, it's recommended to set it between 0 - 0.3 to avoid hallucinations and ensure the model judges the output correctly based on the instructions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.<br/>
        /// If your Judge instructions return `true` or `false` takes only 1 token (as per the OpenAI Tokenizer), and therefore is recommended to set it to a low number to force the model to return a short response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// These are the messages which will instruct the AI Judge on how to evaluate the assistant message.<br/>
        /// The LLM-Judge must respond with "pass" or "fail" to indicate if the assistant message passes the eval.<br/>
        /// To access the messages in the mock conversation, use the LiquidJS variable `{{messages}}`.<br/>
        /// The assistant message to be evaluated will be passed as the last message in the `messages` array and can be accessed using `{{messages[-1]}}`.<br/>
        /// It is recommended to use the system message to instruct the LLM how to evaluate the assistant message, and then use the first user message to pass the assistant message to be evaluated.<br/>
        /// Example: {
        /// </summary>
        /// <example>{</example>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalOpenAIModel" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </param>
        /// <param name="messages">
        /// These are the messages which will instruct the AI Judge on how to evaluate the assistant message.<br/>
        /// The LLM-Judge must respond with "pass" or "fail" to indicate if the assistant message passes the eval.<br/>
        /// To access the messages in the mock conversation, use the LiquidJS variable `{{messages}}`.<br/>
        /// The assistant message to be evaluated will be passed as the last message in the `messages` array and can be accessed using `{{messages[-1]}}`.<br/>
        /// It is recommended to use the system message to instruct the LLM how to evaluate the assistant message, and then use the first user message to pass the assistant message to be evaluated.<br/>
        /// Example: {
        /// </param>
        /// <param name="provider">
        /// This is the provider of the model (`openai`).
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model. For LLM-as-a-judge, it's recommended to set it between 0 - 0.3 to avoid hallucinations and ensure the model judges the output correctly based on the instructions.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.<br/>
        /// If your Judge instructions return `true` or `false` takes only 1 token (as per the OpenAI Tokenizer), and therefore is recommended to set it to a low number to force the model to return a short response.
        /// </param>
        public EvalOpenAIModel(
            global::G.EvalOpenAIModelModel model,
            global::System.Collections.Generic.IList<object> messages,
            global::G.EvalOpenAIModelProvider provider,
            double? temperature,
            double? maxTokens)
        {
            this.Provider = provider;
            this.Model = model;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalOpenAIModel" /> class.
        /// </summary>
        public EvalOpenAIModel()
        {
        }
    }
}