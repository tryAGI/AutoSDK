//HintName: G.Models.AgentConfigEnvUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigEnvUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("envs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentConfigEnv> Envs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigEnvUpdate" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="envs"></param>
        public AgentConfigEnvUpdate(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.AgentConfigEnv> envs)
        {
            this.ProjectId = projectId;
            this.Envs = envs ?? throw new global::System.ArgumentNullException(nameof(envs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigEnvUpdate" /> class.
        /// </summary>
        public AgentConfigEnvUpdate()
        {
        }
    }
}