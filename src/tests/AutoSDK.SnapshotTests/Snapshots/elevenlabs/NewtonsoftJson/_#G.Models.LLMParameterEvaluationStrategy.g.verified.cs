//HintName: G.Models.LLMParameterEvaluationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMParameterEvaluationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"llm"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "llm";

        /// <summary>
        /// A description of the evaluation strategy to use for the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description">
        /// A description of the evaluation strategy to use for the test.
        /// </param>
        public LLMParameterEvaluationStrategy(
            string description,
            string type = "llm")
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMParameterEvaluationStrategy" /> class.
        /// </summary>
        public LLMParameterEvaluationStrategy()
        {
        }
    }
}