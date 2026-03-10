//HintName: G.Models.TransferBranchInfoTrafficSplit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferBranchInfoTrafficSplit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"traffic_split"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_reason")]
        public string BranchReason { get; set; } = "traffic_split";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TrafficPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoTrafficSplit" /> class.
        /// </summary>
        /// <param name="branchReason"></param>
        /// <param name="branchId"></param>
        /// <param name="trafficPercentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferBranchInfoTrafficSplit(
            string branchId,
            double trafficPercentage,
            string branchReason = "traffic_split")
        {
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.TrafficPercentage = trafficPercentage;
            this.BranchReason = branchReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoTrafficSplit" /> class.
        /// </summary>
        public TransferBranchInfoTrafficSplit()
        {
        }
    }
}