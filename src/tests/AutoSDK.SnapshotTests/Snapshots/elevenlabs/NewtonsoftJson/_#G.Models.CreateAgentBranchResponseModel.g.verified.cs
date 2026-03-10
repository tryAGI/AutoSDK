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
        [global::Newtonsoft.Json.JsonProperty("created_branch_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBranchId { get; set; } = default!;

        /// <summary>
        /// ID of the first version on the created branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedVersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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