//HintName: G.Models.CreateAgentBranchResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentBranchResponseModel
    {
        /// <summary>
        /// ID of the created branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBranchId { get; set; }

        /// <summary>
        /// ID of the first version on the created branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentBranchResponseModel" /> class.
        /// </summary>
        /// <param name="createdBranchId">
        /// ID of the created branch
        /// </param>
        /// <param name="createdVersionId">
        /// ID of the first version on the created branch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentBranchResponseModel(
            string createdBranchId,
            string createdVersionId)
        {
            this.CreatedBranchId = createdBranchId ?? throw new global::System.ArgumentNullException(nameof(createdBranchId));
            this.CreatedVersionId = createdVersionId ?? throw new global::System.ArgumentNullException(nameof(createdVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentBranchResponseModel" /> class.
        /// </summary>
        public CreateAgentBranchResponseModel()
        {
        }
    }
}