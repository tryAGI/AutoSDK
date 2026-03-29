//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseResult
    {
        /// <summary>
        /// 1-based index of the query in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Index { get; set; }

        /// <summary>
        /// The use case that was searched
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UseCase { get; set; }

        /// <summary>
        /// Guidance message about the search results, particularly when a cached plan is available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_guidance")]
        public string? ExecutionGuidance { get; set; }

        /// <summary>
        /// Task difficulty assessment (e.g., "easy - Simple single-tool operation with known parameters")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("difficulty")]
        public string? Difficulty { get; set; }

        /// <summary>
        /// Workflow steps from cached plan (only present when cached plan is available)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommended_plan_steps")]
        public global::System.Collections.Generic.IList<string>? RecommendedPlanSteps { get; set; }

        /// <summary>
        /// Common pitfalls and considerations (only present when cached plan is available)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("known_pitfalls")]
        public global::System.Collections.Generic.IList<string>? KnownPitfalls { get; set; }

        /// <summary>
        /// Reference Python code snippets for processing tool responses in the workbench (only present when cached plan is available)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_workbench_snippets")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>? ReferenceWorkbenchSnippets { get; set; }

        /// <summary>
        /// List of main tool slugs matching the search criteria
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_tool_slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PrimaryToolSlugs { get; set; }

        /// <summary>
        /// List of related tool slugs that might be useful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related_tool_slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RelatedToolSlugs { get; set; }

        /// <summary>
        /// List of unique toolkit slugs used by tools in this query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Toolkits { get; set; }

        /// <summary>
        /// ID of cached plan if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string? PlanId { get; set; }

        /// <summary>
        /// Error message if the search for this query failed, null otherwise. Always present for failed queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Memory data relevant to this query, grouped by app. Only present for non-cached search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseResult" /> class.
        /// </summary>
        /// <param name="index">
        /// 1-based index of the query in the request
        /// </param>
        /// <param name="useCase">
        /// The use case that was searched
        /// </param>
        /// <param name="primaryToolSlugs">
        /// List of main tool slugs matching the search criteria
        /// </param>
        /// <param name="relatedToolSlugs">
        /// List of related tool slugs that might be useful
        /// </param>
        /// <param name="toolkits">
        /// List of unique toolkit slugs used by tools in this query
        /// </param>
        /// <param name="executionGuidance">
        /// Guidance message about the search results, particularly when a cached plan is available
        /// </param>
        /// <param name="difficulty">
        /// Task difficulty assessment (e.g., "easy - Simple single-tool operation with known parameters")
        /// </param>
        /// <param name="recommendedPlanSteps">
        /// Workflow steps from cached plan (only present when cached plan is available)
        /// </param>
        /// <param name="knownPitfalls">
        /// Common pitfalls and considerations (only present when cached plan is available)
        /// </param>
        /// <param name="referenceWorkbenchSnippets">
        /// Reference Python code snippets for processing tool responses in the workbench (only present when cached plan is available)
        /// </param>
        /// <param name="planId">
        /// ID of cached plan if available
        /// </param>
        /// <param name="error">
        /// Error message if the search for this query failed, null otherwise. Always present for failed queries.
        /// </param>
        /// <param name="memory">
        /// Memory data relevant to this query, grouped by app. Only present for non-cached search results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseResult(
            double index,
            string useCase,
            global::System.Collections.Generic.IList<string> primaryToolSlugs,
            global::System.Collections.Generic.IList<string> relatedToolSlugs,
            global::System.Collections.Generic.IList<string> toolkits,
            string? executionGuidance,
            string? difficulty,
            global::System.Collections.Generic.IList<string>? recommendedPlanSteps,
            global::System.Collections.Generic.IList<string>? knownPitfalls,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>? referenceWorkbenchSnippets,
            string? planId,
            string? error,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? memory)
        {
            this.Index = index;
            this.UseCase = useCase ?? throw new global::System.ArgumentNullException(nameof(useCase));
            this.ExecutionGuidance = executionGuidance;
            this.Difficulty = difficulty;
            this.RecommendedPlanSteps = recommendedPlanSteps;
            this.KnownPitfalls = knownPitfalls;
            this.ReferenceWorkbenchSnippets = referenceWorkbenchSnippets;
            this.PrimaryToolSlugs = primaryToolSlugs ?? throw new global::System.ArgumentNullException(nameof(primaryToolSlugs));
            this.RelatedToolSlugs = relatedToolSlugs ?? throw new global::System.ArgumentNullException(nameof(relatedToolSlugs));
            this.Toolkits = toolkits ?? throw new global::System.ArgumentNullException(nameof(toolkits));
            this.PlanId = planId;
            this.Error = error;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseResult" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseResult()
        {
        }
    }
}