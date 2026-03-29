//HintName: G.Models.TemplatesGetTemplateSnapshotResponseRelationship.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseRelationship
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agentEntityId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentEntityId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blockEntityId", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlockEntityId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseRelationship" /> class.
        /// </summary>
        /// <param name="agentEntityId"></param>
        /// <param name="blockEntityId"></param>
        public TemplatesGetTemplateSnapshotResponseRelationship(
            string agentEntityId,
            string blockEntityId)
        {
            this.AgentEntityId = agentEntityId ?? throw new global::System.ArgumentNullException(nameof(agentEntityId));
            this.BlockEntityId = blockEntityId ?? throw new global::System.ArgumentNullException(nameof(blockEntityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseRelationship" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseRelationship()
        {
        }
    }
}