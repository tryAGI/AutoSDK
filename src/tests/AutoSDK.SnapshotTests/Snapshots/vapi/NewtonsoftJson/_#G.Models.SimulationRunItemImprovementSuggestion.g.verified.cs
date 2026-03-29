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
        [global::Newtonsoft.Json.JsonProperty("issue", Required = global::Newtonsoft.Json.Required.Always)]
        public string Issue { get; set; } = default!;

        /// <summary>
        /// This is the suggested improvement.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggestion", Required = global::Newtonsoft.Json.Required.Always)]
        public string Suggestion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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