//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponse
    {
        /// <summary>
        /// Whether all searches completed successfully. False if any query failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Error message if any searches failed, null if all succeeded. Format: "X out of Y searches failed, reasons: &lt;details&gt;"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Per-query search results with tools, reasoning, and memory. One entry per query in request order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseResult> Results { get; set; }

        /// <summary>
        /// Connection status for all toolkits mentioned across all queries, with descriptions merged in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_connection_statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse> ToolkitConnectionStatuses { get; set; }

        /// <summary>
        /// Deduplicated tool definitions keyed by tool_slug for O(1) lookup. Each tool appears once even if used in multiple queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2> ToolSchemas { get; set; }

        /// <summary>
        /// Time information for the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolRouterSessionBySessionIdSearchResponseTimeInfo TimeInfo { get; set; }

        /// <summary>
        /// Session info for correlating meta tool calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolRouterSessionBySessionIdSearchResponseSession Session { get; set; }

        /// <summary>
        /// Combined workflow guidance covering connections, planner, and memory usage. Each element is a step instruction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_steps_guidance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NextStepsGuidance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether all searches completed successfully. False if any query failed.
        /// </param>
        /// <param name="results">
        /// Per-query search results with tools, reasoning, and memory. One entry per query in request order.
        /// </param>
        /// <param name="toolkitConnectionStatuses">
        /// Connection status for all toolkits mentioned across all queries, with descriptions merged in.
        /// </param>
        /// <param name="toolSchemas">
        /// Deduplicated tool definitions keyed by tool_slug for O(1) lookup. Each tool appears once even if used in multiple queries.
        /// </param>
        /// <param name="timeInfo">
        /// Time information for the query
        /// </param>
        /// <param name="session">
        /// Session info for correlating meta tool calls
        /// </param>
        /// <param name="nextStepsGuidance">
        /// Combined workflow guidance covering connections, planner, and memory usage. Each element is a step instruction.
        /// </param>
        /// <param name="error">
        /// Error message if any searches failed, null if all succeeded. Format: "X out of Y searches failed, reasons: &lt;details&gt;"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponse(
            bool success,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseResult> results,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse> toolkitConnectionStatuses,
            global::System.Collections.Generic.Dictionary<string, global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2> toolSchemas,
            global::G.PostToolRouterSessionBySessionIdSearchResponseTimeInfo timeInfo,
            global::G.PostToolRouterSessionBySessionIdSearchResponseSession session,
            global::System.Collections.Generic.IList<string> nextStepsGuidance,
            string? error)
        {
            this.Success = success;
            this.Error = error;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.ToolkitConnectionStatuses = toolkitConnectionStatuses ?? throw new global::System.ArgumentNullException(nameof(toolkitConnectionStatuses));
            this.ToolSchemas = toolSchemas ?? throw new global::System.ArgumentNullException(nameof(toolSchemas));
            this.TimeInfo = timeInfo ?? throw new global::System.ArgumentNullException(nameof(timeInfo));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.NextStepsGuidance = nextStepsGuidance ?? throw new global::System.ArgumentNullException(nameof(nextStepsGuidance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponse" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponse()
        {
        }
    }
}