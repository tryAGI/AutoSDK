//HintName: G.Models.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_reason")]
        public global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason? BranchReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="branchReason"></param>
        public TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator(
            global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason? branchReason)
        {
            this.BranchReason = branchReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator" /> class.
        /// </summary>
        public TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator()
        {
        }
    }
}