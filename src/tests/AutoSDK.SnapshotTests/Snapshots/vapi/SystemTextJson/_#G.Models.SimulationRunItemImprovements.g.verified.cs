//HintName: G.Models.SimulationRunItemImprovements.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemImprovements
    {
        /// <summary>
        /// This is a summary analysis of why evaluations failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Analysis { get; set; }

        /// <summary>
        /// This is the list of suggestions for improving the system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPromptSuggestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SimulationRunItemImprovementSuggestion> SystemPromptSuggestions { get; set; }

        /// <summary>
        /// This is the list of suggestions for improving tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolSuggestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SimulationRunItemImprovementSuggestion> ToolSuggestions { get; set; }

        /// <summary>
        /// This is the list of suggestions for improving the scenario/evaluation plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioSuggestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SimulationRunItemImprovementSuggestion> ScenarioSuggestions { get; set; }

        /// <summary>
        /// This is a complete revised system prompt if major changes are needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestedSystemPrompt")]
        public string? SuggestedSystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemImprovements" /> class.
        /// </summary>
        /// <param name="analysis">
        /// This is a summary analysis of why evaluations failed.
        /// </param>
        /// <param name="systemPromptSuggestions">
        /// This is the list of suggestions for improving the system prompt.
        /// </param>
        /// <param name="toolSuggestions">
        /// This is the list of suggestions for improving tools.
        /// </param>
        /// <param name="scenarioSuggestions">
        /// This is the list of suggestions for improving the scenario/evaluation plan.
        /// </param>
        /// <param name="suggestedSystemPrompt">
        /// This is a complete revised system prompt if major changes are needed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemImprovements(
            string analysis,
            global::System.Collections.Generic.IList<global::G.SimulationRunItemImprovementSuggestion> systemPromptSuggestions,
            global::System.Collections.Generic.IList<global::G.SimulationRunItemImprovementSuggestion> toolSuggestions,
            global::System.Collections.Generic.IList<global::G.SimulationRunItemImprovementSuggestion> scenarioSuggestions,
            string? suggestedSystemPrompt)
        {
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
            this.SystemPromptSuggestions = systemPromptSuggestions ?? throw new global::System.ArgumentNullException(nameof(systemPromptSuggestions));
            this.ToolSuggestions = toolSuggestions ?? throw new global::System.ArgumentNullException(nameof(toolSuggestions));
            this.ScenarioSuggestions = scenarioSuggestions ?? throw new global::System.ArgumentNullException(nameof(scenarioSuggestions));
            this.SuggestedSystemPrompt = suggestedSystemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemImprovements" /> class.
        /// </summary>
        public SimulationRunItemImprovements()
        {
        }
    }
}