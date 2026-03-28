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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "regex";

        /// <summary>
        /// A regex pattern to match the agent's response against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="pattern">
        /// A regex pattern to match the agent's response against.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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