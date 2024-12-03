//HintName: G.Models.ActionsCacheUsageOrgEnterprise.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsCacheUsageOrgEnterprise
    {
        /// <summary>
        /// The count of active caches across all repositories of an enterprise or an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_active_caches_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalActiveCachesCount { get; set; } = default!;

        /// <summary>
        /// The total size in bytes of all active cache items across all repositories of an enterprise or an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_active_caches_size_in_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalActiveCachesSizeInBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheUsageOrgEnterprise" /> class.
        /// </summary>
        /// <param name="totalActiveCachesCount">
        /// The count of active caches across all repositories of an enterprise or an organization.
        /// </param>
        /// <param name="totalActiveCachesSizeInBytes">
        /// The total size in bytes of all active cache items across all repositories of an enterprise or an organization.
        /// </param>
        public ActionsCacheUsageOrgEnterprise(
            int totalActiveCachesCount,
            int totalActiveCachesSizeInBytes)
        {
            this.TotalActiveCachesCount = totalActiveCachesCount;
            this.TotalActiveCachesSizeInBytes = totalActiveCachesSizeInBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheUsageOrgEnterprise" /> class.
        /// </summary>
        public ActionsCacheUsageOrgEnterprise()
        {
        }
    }
}