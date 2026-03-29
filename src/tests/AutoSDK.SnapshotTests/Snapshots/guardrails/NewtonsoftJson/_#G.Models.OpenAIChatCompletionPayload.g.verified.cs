//HintName: G.Models.OpenAIChatCompletionPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI-compatible chat completion request payload.
    /// </summary>
    public sealed partial class OpenAIChatCompletionPayload
    {
        /// <summary>
        /// The model to use for the completion<br/>
        /// Example: gpt-3.5-turbo
        /// </summary>
        /// <example>gpt-3.5-turbo</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The messages to use for the completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OpenAIChatMessage>? Messages { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The sampling temperature
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletionPayload" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for the completion<br/>
        /// Example: gpt-3.5-turbo
        /// </param>
        /// <param name="messages">
        /// The messages to use for the completion
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature
        /// </param>
        public OpenAIChatCompletionPayload(
            string? model,
            global::System.Collections.Generic.IList<global::G.OpenAIChatMessage>? messages,
            int? maxTokens,
            double? temperature)
        {
            this.Model = model;
            this.Messages = messages;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletionPayload" /> class.
        /// </summary>
        public OpenAIChatCompletionPayload()
        {
        }
    }
}