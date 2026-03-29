//HintName: G.Models.EvalGroqModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalGroqModel
    {
        /// <summary>
        /// This is the provider of the model (`groq`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalGroqModelProviderJsonConverter))]
        public global::G.EvalGroqModelProvider Provider { get; set; }

        /// <summary>
        /// This is the name of the model. Ex. gpt-4o
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalGroqModelModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalGroqModelModel Model { get; set; }

        /// <summary>
        /// This is the temperature of the model. For LLM-as-a-judge, it's recommended to set it between 0 - 0.3 to avoid hallucinations and ensure the model judges the output correctly based on the instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.<br/>
        /// If your Judge instructions return `true` or `false` takes only 1 token (as per the OpenAI Tokenizer), and therefore is recommended to set it to a low number to force the model to return a short response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
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
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalGroqModel" /> class.
        /// </summary>
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
        /// This is the provider of the model (`groq`).
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model. For LLM-as-a-judge, it's recommended to set it between 0 - 0.3 to avoid hallucinations and ensure the model judges the output correctly based on the instructions.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.<br/>
        /// If your Judge instructions return `true` or `false` takes only 1 token (as per the OpenAI Tokenizer), and therefore is recommended to set it to a low number to force the model to return a short response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalGroqModel(
            global::G.EvalGroqModelModel model,
            global::System.Collections.Generic.IList<object> messages,
            global::G.EvalGroqModelProvider provider,
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
        /// Initializes a new instance of the <see cref="EvalGroqModel" /> class.
        /// </summary>
        public EvalGroqModel()
        {
        }
    }
}