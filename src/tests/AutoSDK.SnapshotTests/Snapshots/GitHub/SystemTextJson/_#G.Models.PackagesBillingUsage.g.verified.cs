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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_gigabytes_bandwidth_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalGigabytesBandwidthUsed { get; set; }

        /// <summary>
        /// Total paid storage space (GB) for GitHuub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_paid_gigabytes_bandwidth_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPaidGigabytesBandwidthUsed { get; set; }

        /// <summary>
        /// Free storage space (GB) for GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_gigabytes_bandwidth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IncludedGigabytesBandwidth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}