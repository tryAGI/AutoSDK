//HintName: G.Models.ProjectApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual API key in a project.
    /// </summary>
    public sealed partial class ProjectApiKey
    {
        /// <summary>
        /// The object type, which is always `organization.project.api_key`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectApiKeyObject Object { get; set; }

        /// <summary>
        /// The redacted value of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redacted_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string RedactedValue { get; set; } = default!;

        /// <summary>
        /// The name of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was last used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset LastUsedAt { get; set; } = default!;

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectApiKeyOwner Owner { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKey" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `organization.project.api_key`
        /// </param>
        /// <param name="redactedValue">
        /// The redacted value of the API key
        /// </param>
        /// <param name="name">
        /// The name of the API key
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the API key was created
        /// </param>
        /// <param name="lastUsedAt">
        /// The Unix timestamp (in seconds) of when the API key was last used.
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="owner"></param>
        public ProjectApiKey(
            string redactedValue,
            string name,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset lastUsedAt,
            string id,
            global::G.ProjectApiKeyOwner owner,
            global::G.ProjectApiKeyObject @object)
        {
            this.RedactedValue = redactedValue ?? throw new global::System.ArgumentNullException(nameof(redactedValue));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKey" /> class.
        /// </summary>
        public ProjectApiKey()
        {
        }
    }
}