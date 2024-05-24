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
    }
}