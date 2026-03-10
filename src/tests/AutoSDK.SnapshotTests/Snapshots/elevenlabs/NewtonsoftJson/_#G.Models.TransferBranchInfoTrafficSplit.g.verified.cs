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
        [global::Newtonsoft.Json.JsonProperty("branch_reason")]
        public string BranchReason { get; set; } = "traffic_split";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traffic_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double TrafficPercentage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoTrafficSplit" /> class.
        /// </summary>
        /// <param name="branchReason"></param>
        /// <param name="branchId"></param>
        /// <param name="trafficPercentage"></param>
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