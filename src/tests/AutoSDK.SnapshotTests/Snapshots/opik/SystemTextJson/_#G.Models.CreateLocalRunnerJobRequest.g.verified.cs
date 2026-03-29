//HintName: G.Models.CreateLocalRunnerJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLocalRunnerJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::G.JsonNode? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_id")]
        public global::System.Guid? MaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.LocalRunnerJobMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLocalRunnerJobRequest" /> class.
        /// </summary>
        /// <param name="agentName"></param>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="maskId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLocalRunnerJobRequest(
            string agentName,
            global::System.Guid projectId,
            global::G.JsonNode? inputs,
            global::System.Guid? maskId,
            global::G.LocalRunnerJobMetadata? metadata)
        {
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.Inputs = inputs;
            this.ProjectId = projectId;
            this.MaskId = maskId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLocalRunnerJobRequest" /> class.
        /// </summary>
        public CreateLocalRunnerJobRequest()
        {
        }
    }
}