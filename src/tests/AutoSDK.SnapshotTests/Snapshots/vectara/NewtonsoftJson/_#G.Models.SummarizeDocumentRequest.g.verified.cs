//HintName: G.Models.SummarizeDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to summarize a document
    /// </summary>
    public sealed partial class SummarizeDocumentRequest
    {
        /// <summary>
        /// The name of the LLM.<br/>
        /// Example: mockingbird-2.0
        /// </summary>
        /// <example>mockingbird-2.0</example>
        [global::Newtonsoft.Json.JsonProperty("llm_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string LlmName { get; set; } = default!;

        /// <summary>
        /// The prompt template to use when generating the summary. Vectara manages both system and user roles and prompts for the generative LLM out of the box by default. However, users can override the `prompt_template` via this variable. The `prompt_template` is in the form of an Apache Velocity template. For more details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: Provide a concise summary of the document.
        /// </summary>
        /// <example>Provide a concise summary of the document.</example>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Optional parameters for the specified model used when generating the summary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeDocumentRequest" /> class.
        /// </summary>
        /// <param name="llmName">
        /// The name of the LLM.<br/>
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template to use when generating the summary. Vectara manages both system and user roles and prompts for the generative LLM out of the box by default. However, users can override the `prompt_template` via this variable. The `prompt_template` is in the form of an Apache Velocity template. For more details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: Provide a concise summary of the document.
        /// </param>
        /// <param name="modelParameters">
        /// Optional parameters for the specified model used when generating the summary.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        public SummarizeDocumentRequest(
            string llmName,
            string? promptTemplate,
            object? modelParameters,
            bool? streamResponse)
        {
            this.LlmName = llmName ?? throw new global::System.ArgumentNullException(nameof(llmName));
            this.PromptTemplate = promptTemplate;
            this.ModelParameters = modelParameters;
            this.StreamResponse = streamResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeDocumentRequest" /> class.
        /// </summary>
        public SummarizeDocumentRequest()
        {
        }
    }
}