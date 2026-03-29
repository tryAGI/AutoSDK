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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Error message if any searches failed, null if all succeeded. Format: "X out of Y searches failed, reasons: &lt;details&gt;"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Per-query search results with tools, reasoning, and memory. One entry per query in request order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// Connection status for all toolkits mentioned across all queries, with descriptions merged in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkit_connection_statuses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse> ToolkitConnectionStatuses { get; set; } = default!;

        /// <summary>
        /// Deduplicated tool definitions keyed by tool_slug for O(1) lookup. Each tool appears once even if used in multiple queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_schemas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2> ToolSchemas { get; set; } = default!;

        /// <summary>
        /// Time information for the query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseTimeInfo TimeInfo { get; set; } = default!;

        /// <summary>
        /// Session info for correlating meta tool calls
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseSession Session { get; set; } = default!;

        /// <summary>
        /// Combined workflow guidance covering connections, planner, and memory usage. Each element is a step instruction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_steps_guidance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> NextStepsGuidance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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