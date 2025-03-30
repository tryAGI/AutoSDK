//HintName: G.Models.GenerationInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event containing information on how the generation was accomplished.
    /// </summary>
    public sealed partial class GenerationInfo
    {
        /// <summary>
        /// When the streaming event contains the generation information<br/>
        /// type will be `generation_info`.<br/>
        /// Default Value: generation_info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// View the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rephrased_query")]
        public string? RephrasedQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationInfo" /> class.
        /// </summary>
        /// <param name="type">
        /// When the streaming event contains the generation information<br/>
        /// type will be `generation_info`.<br/>
        /// Default Value: generation_info
        /// </param>
        /// <param name="renderedPrompt">
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates.
        /// </param>
        /// <param name="rephrasedQuery">
        /// View the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationInfo(
            string? type,
            string? renderedPrompt,
            string? rephrasedQuery)
        {
            this.Type = type;
            this.RenderedPrompt = renderedPrompt;
            this.RephrasedQuery = rephrasedQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationInfo" /> class.
        /// </summary>
        public GenerationInfo()
        {
        }
    }
}