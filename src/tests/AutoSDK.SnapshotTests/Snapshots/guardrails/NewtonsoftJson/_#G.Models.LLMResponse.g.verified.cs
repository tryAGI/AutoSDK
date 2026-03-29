//HintName: G.Models.LLMResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information from the LLM response.
    /// </summary>
    public sealed partial class LLMResponse
    {
        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokenCount")]
        public int? PromptTokenCount { get; set; }

        /// <summary>
        /// Number of tokens in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseTokenCount")]
        public int? ResponseTokenCount { get; set; }

        /// <summary>
        /// The LLM output text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public string Output { get; set; } = default!;

        /// <summary>
        /// Stream output chunks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streamOutput")]
        public global::System.Collections.Generic.IList<string>? StreamOutput { get; set; }

        /// <summary>
        /// Async stream output chunks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asyncStreamOutput")]
        public global::System.Collections.Generic.IList<string>? AsyncStreamOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponse" /> class.
        /// </summary>
        /// <param name="output">
        /// The LLM output text.
        /// </param>
        /// <param name="promptTokenCount">
        /// Number of tokens in the prompt.
        /// </param>
        /// <param name="responseTokenCount">
        /// Number of tokens in the response.
        /// </param>
        /// <param name="streamOutput">
        /// Stream output chunks.
        /// </param>
        /// <param name="asyncStreamOutput">
        /// Async stream output chunks.
        /// </param>
        public LLMResponse(
            string output,
            int? promptTokenCount,
            int? responseTokenCount,
            global::System.Collections.Generic.IList<string>? streamOutput,
            global::System.Collections.Generic.IList<string>? asyncStreamOutput)
        {
            this.PromptTokenCount = promptTokenCount;
            this.ResponseTokenCount = responseTokenCount;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.StreamOutput = streamOutput;
            this.AsyncStreamOutput = asyncStreamOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponse" /> class.
        /// </summary>
        public LLMResponse()
        {
        }
    }
}