//HintName: G.Models.SimulationRunItemImprovementSuggestion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemImprovementSuggestion
    {
        /// <summary>
        /// This is the issue identified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issue { get; set; }

        /// <summary>
        /// This is the suggested improvement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Suggestion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemImprovementSuggestion" /> class.
        /// </summary>
        /// <param name="issue">
        /// This is the issue identified.
        /// </param>
        /// <param name="suggestion">
        /// This is the suggested improvement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemImprovementSuggestion(
            string issue,
            string suggestion)
        {
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.Suggestion = suggestion ?? throw new global::System.ArgumentNullException(nameof(suggestion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemImprovementSuggestion" /> class.
        /// </summary>
        public SimulationRunItemImprovementSuggestion()
        {
        }
    }
}