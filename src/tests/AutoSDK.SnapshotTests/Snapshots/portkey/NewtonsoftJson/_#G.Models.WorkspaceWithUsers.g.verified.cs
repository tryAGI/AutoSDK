//HintName: G.Models.WorkspaceWithUsers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceWithUsers
    {
        /// <summary>
        /// Example: ws-test-a-174eb1
        /// </summary>
        /// <example>ws-test-a-174eb1</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: ws-test-a-174eb1
        /// </summary>
        /// <example>ws-test-a-174eb1</example>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Example: New Workspace
        /// </summary>
        /// <example>New Workspace</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: 2024-07-30 13:27:29+00:00
        /// </summary>
        /// <example>2024-07-30 13:27:29+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: 2024-07-30 13:27:29+00:00
        /// </summary>
        /// <example>2024-07-30 13:27:29+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaults")]
        public global::G.WorkspaceWithUsersDefaults? Defaults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceMember>? Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::System.Collections.Generic.IList<global::G.UsageLimits>? UsageLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.RateLimits>? RateLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWithUsers" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: ws-test-a-174eb1
        /// </param>
        /// <param name="slug">
        /// Example: ws-test-a-174eb1
        /// </param>
        /// <param name="name">
        /// Example: New Workspace
        /// </param>
        /// <param name="description">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="createdAt">
        /// Example: 2024-07-30 13:27:29+00:00
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Example: 2024-07-30 13:27:29+00:00
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="users"></param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
        public WorkspaceWithUsers(
            string? id,
            string? slug,
            string? name,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::G.WorkspaceWithUsersDefaults? defaults,
            global::System.Collections.Generic.IList<global::G.WorkspaceMember>? users,
            global::System.Collections.Generic.IList<global::G.UsageLimits>? usageLimits,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits)
        {
            this.Id = id;
            this.Slug = slug;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Defaults = defaults;
            this.Users = users;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWithUsers" /> class.
        /// </summary>
        public WorkspaceWithUsers()
        {
        }
    }
}