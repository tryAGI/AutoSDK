//HintName: G.Models.GetAuthSessionInfoResponseApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the API key used for authentication (null if using session auth)
    /// </summary>
    public sealed partial class GetAuthSessionInfoResponseApiKey
    {
        /// <summary>
        /// Internal auto-incrementing ID for the API key<br/>
        /// Example: 7890
        /// </summary>
        /// <example>7890</example>
        [global::Newtonsoft.Json.JsonProperty("auto_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double AutoId { get; set; } = default!;

        /// <summary>
        /// UUID identifier for the API key<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440003
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440003</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// User-defined name for the API key<br/>
        /// Example: Development Key
        /// </summary>
        /// <example>Development Key</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Short, URL-friendly unique identifier for the associated project<br/>
        /// Example: proj_abc123xyz456
        /// </summary>
        /// <example>proj_abc123xyz456</example>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// UUID identifier for the organization member who owns this API key<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440002
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440002</example>
        [global::Newtonsoft.Json.JsonProperty("org_member_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgMemberId { get; set; } = default!;

        /// <summary>
        /// Date and time when the API key was created<br/>
        /// Example: 2023-05-01T10:00:00.000Z
        /// </summary>
        /// <example>2023-05-01T10:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Date and time when the API key was last modified<br/>
        /// Example: 2023-05-01T10:00:00.000Z
        /// </summary>
        /// <example>2023-05-01T10:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Date and time when the API key was deleted (if applicable)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public string? DeletedAt { get; set; }

        /// <summary>
        /// The actual API key value (usually only shown once during creation)<br/>
        /// Example: sk_live_abc123xyz456
        /// </summary>
        /// <example>sk_live_abc123xyz456</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Flag indicating if the API key has been deleted<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseApiKey" /> class.
        /// </summary>
        /// <param name="autoId">
        /// Internal auto-incrementing ID for the API key<br/>
        /// Example: 7890
        /// </param>
        /// <param name="id">
        /// UUID identifier for the API key<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440003
        /// </param>
        /// <param name="name">
        /// User-defined name for the API key<br/>
        /// Example: Development Key
        /// </param>
        /// <param name="projectId">
        /// Short, URL-friendly unique identifier for the associated project<br/>
        /// Example: proj_abc123xyz456
        /// </param>
        /// <param name="orgMemberId">
        /// UUID identifier for the organization member who owns this API key<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440002
        /// </param>
        /// <param name="createdAt">
        /// Date and time when the API key was created<br/>
        /// Example: 2023-05-01T10:00:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Date and time when the API key was last modified<br/>
        /// Example: 2023-05-01T10:00:00.000Z
        /// </param>
        /// <param name="key">
        /// The actual API key value (usually only shown once during creation)<br/>
        /// Example: sk_live_abc123xyz456
        /// </param>
        /// <param name="deleted">
        /// Flag indicating if the API key has been deleted<br/>
        /// Example: false
        /// </param>
        /// <param name="deletedAt">
        /// Date and time when the API key was deleted (if applicable)
        /// </param>
        public GetAuthSessionInfoResponseApiKey(
            double autoId,
            string id,
            string name,
            string projectId,
            string orgMemberId,
            string createdAt,
            string updatedAt,
            string key,
            bool deleted,
            string? deletedAt)
        {
            this.AutoId = autoId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OrgMemberId = orgMemberId ?? throw new global::System.ArgumentNullException(nameof(orgMemberId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.DeletedAt = deletedAt;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseApiKey" /> class.
        /// </summary>
        public GetAuthSessionInfoResponseApiKey()
        {
        }
    }
}