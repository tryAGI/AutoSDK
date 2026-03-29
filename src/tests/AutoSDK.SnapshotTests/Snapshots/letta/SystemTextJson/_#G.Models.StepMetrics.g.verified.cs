//HintName: G.Models.StepMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepMetrics
    {
        /// <summary>
        /// The id of the step this metric belongs to (matches steps.id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique identifier of the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// The unique identifier of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// The unique identifier of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The timestamp of the start of the step in nanoseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_start_ns")]
        public long? StepStartNs { get; set; }

        /// <summary>
        /// The timestamp of the start of the llm request in nanoseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_request_start_ns")]
        public long? LlmRequestStartNs { get; set; }

        /// <summary>
        /// Time spent on LLM requests in nanoseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_request_ns")]
        public long? LlmRequestNs { get; set; }

        /// <summary>
        /// Time spent on tool execution in nanoseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_execution_ns")]
        public long? ToolExecutionNs { get; set; }

        /// <summary>
        /// Total time for the step in nanoseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_ns")]
        public long? StepNs { get; set; }

        /// <summary>
        /// The base template ID that the step belongs to (cloud only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// The template ID that the step belongs to (cloud only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The project that the step belongs to (cloud only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepMetrics" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the step this metric belongs to (matches steps.id).
        /// </param>
        /// <param name="providerId">
        /// The unique identifier of the provider.
        /// </param>
        /// <param name="runId">
        /// The unique identifier of the run.
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent.
        /// </param>
        /// <param name="stepStartNs">
        /// The timestamp of the start of the step in nanoseconds.
        /// </param>
        /// <param name="llmRequestStartNs">
        /// The timestamp of the start of the llm request in nanoseconds.
        /// </param>
        /// <param name="llmRequestNs">
        /// Time spent on LLM requests in nanoseconds.
        /// </param>
        /// <param name="toolExecutionNs">
        /// Time spent on tool execution in nanoseconds.
        /// </param>
        /// <param name="stepNs">
        /// Total time for the step in nanoseconds.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template ID that the step belongs to (cloud only).
        /// </param>
        /// <param name="templateId">
        /// The template ID that the step belongs to (cloud only).
        /// </param>
        /// <param name="projectId">
        /// The project that the step belongs to (cloud only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepMetrics(
            string id,
            string? providerId,
            string? runId,
            string? agentId,
            long? stepStartNs,
            long? llmRequestStartNs,
            long? llmRequestNs,
            long? toolExecutionNs,
            long? stepNs,
            string? baseTemplateId,
            string? templateId,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProviderId = providerId;
            this.RunId = runId;
            this.AgentId = agentId;
            this.StepStartNs = stepStartNs;
            this.LlmRequestStartNs = llmRequestStartNs;
            this.LlmRequestNs = llmRequestNs;
            this.ToolExecutionNs = toolExecutionNs;
            this.StepNs = stepNs;
            this.BaseTemplateId = baseTemplateId;
            this.TemplateId = templateId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepMetrics" /> class.
        /// </summary>
        public StepMetrics()
        {
        }
    }
}