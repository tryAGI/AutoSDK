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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// If you are on the Scale plan, you can view the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rephrased_query")]
        public string? RephrasedQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </param>
        /// <param name="rephrasedQuery">
        /// If you are on the Scale plan, you can view the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </param>
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