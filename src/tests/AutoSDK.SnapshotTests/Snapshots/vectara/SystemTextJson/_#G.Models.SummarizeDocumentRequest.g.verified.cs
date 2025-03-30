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
        /// The name of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmName { get; set; }

        /// <summary>
        /// The prompt template to use when generating the summary. <br/>
        /// Vectara manages both system and user roles and prompts for the generative<br/>
        /// LLM out of the box by default. However, users can override the<br/>
        /// `prompt_template` via this variable. The `prompt_template` is in the form of an<br/>
        /// Apache Velocity template. For more details on how to configure the<br/>
        /// `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Optional parameters for the specified model used when generating the summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeDocumentRequest" /> class.
        /// </summary>
        /// <param name="llmName">
        /// The name of the LLM.
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template to use when generating the summary. <br/>
        /// Vectara manages both system and user roles and prompts for the generative<br/>
        /// LLM out of the box by default. However, users can override the<br/>
        /// `prompt_template` via this variable. The `prompt_template` is in the form of an<br/>
        /// Apache Velocity template. For more details on how to configure the<br/>
        /// `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).
        /// </param>
        /// <param name="modelParameters">
        /// Optional parameters for the specified model used when generating the summary.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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