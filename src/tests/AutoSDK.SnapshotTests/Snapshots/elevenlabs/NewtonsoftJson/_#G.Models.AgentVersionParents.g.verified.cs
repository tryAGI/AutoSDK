//HintName: G.Models.AgentVersionParents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentVersionParents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_branch_parent_id")]
        public string? InBranchParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("out_of_branch_parent_id")]
        public string? OutOfBranchParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_into_branch_id")]
        public string? MergedIntoBranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_from_branch_id")]
        public string? MergedFromBranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionParents" /> class.
        /// </summary>
        /// <param name="inBranchParentId"></param>
        /// <param name="outOfBranchParentId"></param>
        /// <param name="mergedIntoBranchId"></param>
        /// <param name="mergedFromBranchId"></param>
        public AgentVersionParents(
            string? inBranchParentId,
            string? outOfBranchParentId,
            string? mergedIntoBranchId,
            string? mergedFromBranchId)
        {
            this.InBranchParentId = inBranchParentId;
            this.OutOfBranchParentId = outOfBranchParentId;
            this.MergedIntoBranchId = mergedIntoBranchId;
            this.MergedFromBranchId = mergedFromBranchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionParents" /> class.
        /// </summary>
        public AgentVersionParents()
        {
        }
    }
}