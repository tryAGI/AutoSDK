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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentConfigEnv> Envs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigEnvUpdate" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="envs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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