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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints<br/>
        /// Example: key_abc
        /// </summary>
        /// <example>key_abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the API key<br/>
        /// Example: Administration Key
        /// </summary>
        /// <example>Administration Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The redacted value of the API key<br/>
        /// Example: sk-admin...def
        /// </summary>
        /// <example>sk-admin...def</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedValue { get; set; }

        /// <summary>
        /// The value of the API key. Only shown on create.<br/>
        /// Example: sk-admin-1234abcd
        /// </summary>
        /// <example>sk-admin-1234abcd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was created<br/>
        /// Example: 1711471533L
        /// </summary>
        /// <example>1711471533L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was last used<br/>
        /// Example: 1711471534L
        /// </summary>
        /// <example>1711471534L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AdminApiKeyOwner Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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