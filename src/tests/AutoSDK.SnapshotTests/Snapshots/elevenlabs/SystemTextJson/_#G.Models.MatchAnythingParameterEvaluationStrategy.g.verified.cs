//HintName: G.Models.MatchAnythingParameterEvaluationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MatchAnythingParameterEvaluationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"anything"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "anything";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAnythingParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchAnythingParameterEvaluationStrategy(
            string type = "anything")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAnythingParameterEvaluationStrategy" /> class.
        /// </summary>
        public MatchAnythingParameterEvaluationStrategy()
        {
        }
    }
}