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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_active_caches_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalActiveCachesCount { get; set; }

        /// <summary>
        /// The total size in bytes of all active cache items across all repositories of an enterprise or an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_active_caches_size_in_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalActiveCachesSizeInBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}