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
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_reason")]
        public string BranchReason { get; set; } = "defaulting_to_main";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoDefaultingToMain" /> class.
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="branchReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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