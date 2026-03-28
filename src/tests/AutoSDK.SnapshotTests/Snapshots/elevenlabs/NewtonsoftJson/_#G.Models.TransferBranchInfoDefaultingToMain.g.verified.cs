//HintName: G.Models.TransferBranchInfoDefaultingToMain.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferBranchInfoDefaultingToMain
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"defaulting_to_main"</default>
        [global::Newtonsoft.Json.JsonProperty("branch_reason")]
        public string BranchReason { get; set; } = "defaulting_to_main";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoDefaultingToMain" /> class.
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="branchReason"></param>
        public TransferBranchInfoDefaultingToMain(
            string branchId,
            string branchReason = "defaulting_to_main")
        {
            this.BranchReason = branchReason;
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoDefaultingToMain" /> class.
        /// </summary>
        public TransferBranchInfoDefaultingToMain()
        {
        }
    }
}