//HintName: G.Models.TableGenerationSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for which generation to use during table summarization. If not specified, the platform uses the default summarizer. All parameters are optional and overrides the default values.
    /// </summary>
    public sealed partial class TableGenerationSpec
    {
        /// <summary>
        /// The name of the LLM to use.<br/>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_name")]
        public string? LlmName { get; set; }

        /// <summary>
        /// The prompt template to use when generating the table summary. Vectara manages both system and user roles and prompts for the generative LLM out of the box by default. However, users can override the `prompt_template` via this variable. The `prompt_template` is in the form of an Apache Velocity template. For more details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Optional parameters for the specified model used when generating the table summary.<br/>
        /// Example: {"temperature":0,"max_tokens":512}
        /// </summary>
        /// <example>{"temperature":0,"max_tokens":512}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableGenerationSpec" /> class.
        /// </summary>
        /// <param name="llmName">
        /// The name of the LLM to use.<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template to use when generating the table summary. Vectara manages both system and user roles and prompts for the generative LLM out of the box by default. However, users can override the `prompt_template` via this variable. The `prompt_template` is in the form of an Apache Velocity template. For more details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).
        /// </param>
        /// <param name="modelParameters">
        /// Optional parameters for the specified model used when generating the table summary.<br/>
        /// Example: {"temperature":0,"max_tokens":512}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableGenerationSpec(
            string? llmName,
            string? promptTemplate,
            object? modelParameters)
        {
            this.LlmName = llmName;
            this.PromptTemplate = promptTemplate;
            this.ModelParameters = modelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableGenerationSpec" /> class.
        /// </summary>
        public TableGenerationSpec()
        {
        }
    }
}