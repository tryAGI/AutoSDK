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
        [global::Newtonsoft.Json.JsonProperty("agent_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.JsonNode? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_id")]
        public global::System.Guid? MaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.LocalRunnerJobMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLocalRunnerJobRequest" /> class.
        /// </summary>
        /// <param name="agentName"></param>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="maskId"></param>
        /// <param name="metadata"></param>
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