//HintName: G.Models.AdminApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual Admin API key in an org.
    /// </summary>
    public sealed partial class AdminApiKey
    {
        /// <summary>
        /// The object type, which is always `organization.admin_api_key`<br/>
        /// Example: organization.admin_api_key
        /// </summary>
        /// <example>organization.admin_api_key</example>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// The identifier, which can be referenced in API endpoints<br/>
        /// Example: key_abc
        /// </summary>
        /// <example>key_abc</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the API key<br/>
        /// Example: Administration Key
        /// </summary>
        /// <example>Administration Key</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The redacted value of the API key<br/>
        /// Example: sk-admin...def
        /// </summary>
        /// <example>sk-admin...def</example>
        [global::Newtonsoft.Json.JsonProperty("redacted_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string RedactedValue { get; set; } = default!;

        /// <summary>
        /// The value of the API key. Only shown on create.<br/>
        /// Example: sk-admin-1234abcd
        /// </summary>
        /// <example>sk-admin-1234abcd</example>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was created<br/>
        /// Example: 1711471533L
        /// </summary>
        /// <example>1711471533L</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was last used<br/>
        /// Example: 1711471534L
        /// </summary>
        /// <example>1711471534L</example>
        [global::Newtonsoft.Json.JsonProperty("last_used_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? LastUsedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AdminApiKeyOwner Owner { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKey" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `organization.admin_api_key`<br/>
        /// Example: organization.admin_api_key
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints<br/>
        /// Example: key_abc
        /// </param>
        /// <param name="name">
        /// The name of the API key<br/>
        /// Example: Administration Key
        /// </param>
        /// <param name="redactedValue">
        /// The redacted value of the API key<br/>
        /// Example: sk-admin...def
        /// </param>
        /// <param name="value">
        /// The value of the API key. Only shown on create.<br/>
        /// Example: sk-admin-1234abcd
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the API key was created<br/>
        /// Example: 1711471533L
        /// </param>
        /// <param name="lastUsedAt">
        /// The Unix timestamp (in seconds) of when the API key was last used<br/>
        /// Example: 1711471534L
        /// </param>
        /// <param name="owner"></param>
        public AdminApiKey(
            string @object,
            string id,
            string name,
            string redactedValue,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset? lastUsedAt,
            global::G.AdminApiKeyOwner owner,
            string? value)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RedactedValue = redactedValue ?? throw new global::System.ArgumentNullException(nameof(redactedValue));
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKey" /> class.
        /// </summary>
        public AdminApiKey()
        {
        }
    }
}