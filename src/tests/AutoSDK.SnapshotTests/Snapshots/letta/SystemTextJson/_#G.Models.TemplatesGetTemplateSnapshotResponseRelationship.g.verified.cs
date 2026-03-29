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
        [global::System.Text.Json.Serialization.JsonPropertyName("agentEntityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockEntityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlockEntityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseRelationship" /> class.
        /// </summary>
        /// <param name="agentEntityId"></param>
        /// <param name="blockEntityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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