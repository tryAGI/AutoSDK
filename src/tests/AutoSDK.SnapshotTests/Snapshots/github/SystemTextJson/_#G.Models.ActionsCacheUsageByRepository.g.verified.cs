//HintName: G.Models.ActionsCacheUsageByRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub Actions Cache Usage by repository.
    /// </summary>
    public sealed partial class ActionsCacheUsageByRepository
    {
        /// <summary>
        /// The repository owner and name for the cache usage being shown.<br/>
        /// Example: octo-org/Hello-World
        /// </summary>
        /// <example>octo-org/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// The sum of the size in bytes of all the active cache items in the repository.<br/>
        /// Example: 2322142
        /// </summary>
        /// <example>2322142</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_caches_size_in_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveCachesSizeInBytes { get; set; }

        /// <summary>
        /// The number of active caches in the repository.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_caches_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveCachesCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheUsageByRepository" /> class.
        /// </summary>
        /// <param name="fullName">
        /// The repository owner and name for the cache usage being shown.<br/>
        /// Example: octo-org/Hello-World
        /// </param>
        /// <param name="activeCachesSizeInBytes">
        /// The sum of the size in bytes of all the active cache items in the repository.<br/>
        /// Example: 2322142
        /// </param>
        /// <param name="activeCachesCount">
        /// The number of active caches in the repository.<br/>
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCacheUsageByRepository(
            string fullName,
            int activeCachesSizeInBytes,
            int activeCachesCount)
        {
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.ActiveCachesSizeInBytes = activeCachesSizeInBytes;
            this.ActiveCachesCount = activeCachesCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheUsageByRepository" /> class.
        /// </summary>
        public ActionsCacheUsageByRepository()
        {
        }
    }
}