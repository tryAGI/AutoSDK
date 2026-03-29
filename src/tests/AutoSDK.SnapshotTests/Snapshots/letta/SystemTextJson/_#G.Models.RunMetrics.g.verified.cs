//HintName: G.Models.RunMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunMetrics
    {
        /// <summary>
        /// The id of the run this metric belongs to (matches runs.id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique identifier of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The project that the run belongs to (cloud only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The timestamp of the start of the run in nanoseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_start_ns")]
        public long? RunStartNs { get; set; }

        /// <summary>
        /// Total time for the run in nanoseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_ns")]
        public long? RunNs { get; set; }

        /// <summary>
        /// The number of steps in the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_steps")]
        public int? NumSteps { get; set; }

        /// <summary>
        /// List of tool IDs that were used in this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools_used")]
        public global::System.Collections.Generic.IList<string>? ToolsUsed { get; set; }

        /// <summary>
        /// The template ID that the run belongs to (cloud only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The base template ID that the run belongs to (cloud only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunMetrics" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the run this metric belongs to (matches runs.id).
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent.
        /// </param>
        /// <param name="projectId">
        /// The project that the run belongs to (cloud only).
        /// </param>
        /// <param name="runStartNs">
        /// The timestamp of the start of the run in nanoseconds.
        /// </param>
        /// <param name="runNs">
        /// Total time for the run in nanoseconds.
        /// </param>
        /// <param name="numSteps">
        /// The number of steps in the run.
        /// </param>
        /// <param name="toolsUsed">
        /// List of tool IDs that were used in this run.
        /// </param>
        /// <param name="templateId">
        /// The template ID that the run belongs to (cloud only).
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template ID that the run belongs to (cloud only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunMetrics(
            string id,
            string? agentId,
            string? projectId,
            long? runStartNs,
            long? runNs,
            int? numSteps,
            global::System.Collections.Generic.IList<string>? toolsUsed,
            string? templateId,
            string? baseTemplateId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId;
            this.ProjectId = projectId;
            this.RunStartNs = runStartNs;
            this.RunNs = runNs;
            this.NumSteps = numSteps;
            this.ToolsUsed = toolsUsed;
            this.TemplateId = templateId;
            this.BaseTemplateId = baseTemplateId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunMetrics" /> class.
        /// </summary>
        public RunMetrics()
        {
        }
    }
}