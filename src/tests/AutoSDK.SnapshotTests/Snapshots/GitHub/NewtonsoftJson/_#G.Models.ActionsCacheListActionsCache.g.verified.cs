//HintName: G.Models.ActionsCacheListActionsCache.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsCacheListActionsCache
    {
        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: refs/heads/main
        /// </summary>
        /// <example>refs/heads/main</example>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Example: Linux-node-958aff96db2d75d67787d1e634ae70b659de937b
        /// </summary>
        /// <example>Linux-node-958aff96db2d75d67787d1e634ae70b659de937b</example>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Example: 73885106f58cc52a7df9ec4d4a5622a5614813162cb516c759a30af6bf56e6f0
        /// </summary>
        /// <example>73885106f58cc52a7df9ec4d4a5622a5614813162cb516c759a30af6bf56e6f0</example>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_accessed_at")]
        public global::System.DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::Newtonsoft.Json.JsonProperty("size_in_bytes")]
        public int? SizeInBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheListActionsCache" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 2
        /// </param>
        /// <param name="ref">
        /// Example: refs/heads/main
        /// </param>
        /// <param name="key">
        /// Example: Linux-node-958aff96db2d75d67787d1e634ae70b659de937b
        /// </param>
        /// <param name="version">
        /// Example: 73885106f58cc52a7df9ec4d4a5622a5614813162cb516c759a30af6bf56e6f0
        /// </param>
        /// <param name="lastAccessedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="sizeInBytes">
        /// Example: 1024
        /// </param>
        public ActionsCacheListActionsCache(
            int? id,
            string? @ref,
            string? key,
            string? version,
            global::System.DateTime? lastAccessedAt,
            global::System.DateTime? createdAt,
            int? sizeInBytes)
        {
            this.Id = id;
            this.Ref = @ref;
            this.Key = key;
            this.Version = version;
            this.LastAccessedAt = lastAccessedAt;
            this.CreatedAt = createdAt;
            this.SizeInBytes = sizeInBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheListActionsCache" /> class.
        /// </summary>
        public ActionsCacheListActionsCache()
        {
        }
    }
}