//HintName: G.Models.PackagesBillingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PackagesBillingUsage
    {
        /// <summary>
        /// Sum of the free and paid storage space (GB) for GitHuub Packages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_gigabytes_bandwidth_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalGigabytesBandwidthUsed { get; set; } = default!;

        /// <summary>
        /// Total paid storage space (GB) for GitHuub Packages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_paid_gigabytes_bandwidth_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalPaidGigabytesBandwidthUsed { get; set; } = default!;

        /// <summary>
        /// Free storage space (GB) for GitHub Packages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("included_gigabytes_bandwidth", Required = global::Newtonsoft.Json.Required.Always)]
        public int IncludedGigabytesBandwidth { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackagesBillingUsage" /> class.
        /// </summary>
        /// <param name="totalGigabytesBandwidthUsed">
        /// Sum of the free and paid storage space (GB) for GitHuub Packages.
        /// </param>
        /// <param name="totalPaidGigabytesBandwidthUsed">
        /// Total paid storage space (GB) for GitHuub Packages.
        /// </param>
        /// <param name="includedGigabytesBandwidth">
        /// Free storage space (GB) for GitHub Packages.
        /// </param>
        public PackagesBillingUsage(
            int totalGigabytesBandwidthUsed,
            int totalPaidGigabytesBandwidthUsed,
            int includedGigabytesBandwidth)
        {
            this.TotalGigabytesBandwidthUsed = totalGigabytesBandwidthUsed;
            this.TotalPaidGigabytesBandwidthUsed = totalPaidGigabytesBandwidthUsed;
            this.IncludedGigabytesBandwidth = includedGigabytesBandwidth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackagesBillingUsage" /> class.
        /// </summary>
        public PackagesBillingUsage()
        {
        }
    }
}