//HintName: G.Models.RegexParameterEvaluationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexParameterEvaluationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"regex"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "regex";

        /// <summary>
        /// A regex pattern to match the agent's response against.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pattern { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="pattern">
        /// A regex pattern to match the agent's response against.
        /// </param>
        /// <param name="type"></param>
        public RegexParameterEvaluationStrategy(
            string pattern,
            string type = "regex")
        {
            this.Type = type;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexParameterEvaluationStrategy" /> class.
        /// </summary>
        public RegexParameterEvaluationStrategy()
        {
        }
    }
}