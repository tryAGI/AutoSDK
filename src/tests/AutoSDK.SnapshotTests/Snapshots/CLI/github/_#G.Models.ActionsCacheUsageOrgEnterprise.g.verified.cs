﻿//HintName: G.Models.ActionsCacheUsageOrgEnterprise.g.cs

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheUsageOrgEnterprise" /> class.
        /// </summary>
        /// <param name="totalActiveCachesCount">
        /// The count of active caches across all repositories of an enterprise or an organization.
        /// </param>
        /// <param name="totalActiveCachesSizeInBytes">
        /// The total size in bytes of all active cache items across all repositories of an enterprise or an organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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