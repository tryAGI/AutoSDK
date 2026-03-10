//HintName: G.Models.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch
    {
        /// <summary>
        /// New name for the branch. Must be unique within the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the branch should be archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// The protection level for the branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_status")]
        public global::G.BranchProtectionStatus? ProtectionStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the branch. Must be unique within the agent.
        /// </param>
        /// <param name="isArchived">
        /// Whether the branch should be archived
        /// </param>
        /// <param name="protectionStatus">
        /// The protection level for the branch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch(
            string? name,
            bool? isArchived,
            global::G.BranchProtectionStatus? protectionStatus)
        {
            this.Name = name;
            this.IsArchived = isArchived;
            this.ProtectionStatus = protectionStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch" /> class.
        /// </summary>
        public BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch()
        {
        }
    }
}