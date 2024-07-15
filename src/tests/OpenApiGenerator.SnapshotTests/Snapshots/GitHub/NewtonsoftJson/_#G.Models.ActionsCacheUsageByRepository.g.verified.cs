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
        [global::Newtonsoft.Json.JsonProperty("full_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// The sum of the size in bytes of all the active cache items in the repository.<br/>
        /// Example: 2322142
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_caches_size_in_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int ActiveCachesSizeInBytes { get; set; } = default!;

        /// <summary>
        /// The number of active caches in the repository.<br/>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_caches_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ActiveCachesCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}