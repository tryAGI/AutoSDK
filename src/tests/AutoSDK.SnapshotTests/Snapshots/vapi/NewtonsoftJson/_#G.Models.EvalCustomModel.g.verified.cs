//HintName: G.Models.EvalCustomModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalCustomModel
    {
        /// <summary>
        /// This is the provider of the model (`custom-llm`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EvalCustomModelProviderJsonConverter))]
        public global::G.EvalCustomModelProvider Provider { get; set; }

        /// <summary>
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// These are the headers we'll use for the OpenAI client's `headers`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the name of the model. Ex. gpt-4o
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="EvalCustomModel" /> class.
        /// </summary>
        /// <param name="url">
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </param>
        /// <param name="model">
        /// This is the name of the model. Ex. gpt-4o
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
        /// This is the provider of the model (`custom-llm`).
        /// </param>
        /// <param name="headers">
        /// These are the headers we'll use for the OpenAI client's `headers`.
        /// </param>
        /// <param name="timeoutSeconds">
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model. For LLM-as-a-judge, it's recommended to set it between 0 - 0.3 to avoid hallucinations and ensure the model judges the output correctly based on the instructions.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.<br/>
        /// If your Judge instructions return `true` or `false` takes only 1 token (as per the OpenAI Tokenizer), and therefore is recommended to set it to a low number to force the model to return a short response.
        /// </param>
        public EvalCustomModel(
            string url,
            string model,
            global::System.Collections.Generic.IList<object> messages,
            global::G.EvalCustomModelProvider provider,
            object? headers,
            double? timeoutSeconds,
            double? temperature,
            double? maxTokens)
        {
            this.Provider = provider;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.TimeoutSeconds = timeoutSeconds;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalCustomModel" /> class.
        /// </summary>
        public EvalCustomModel()
        {
        }
    }
}