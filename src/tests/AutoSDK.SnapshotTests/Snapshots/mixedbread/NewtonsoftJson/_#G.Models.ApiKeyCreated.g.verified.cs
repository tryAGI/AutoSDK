//HintName: G.Models.ApiKeyCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for creating an API key.
    /// </summary>
    public sealed partial class ApiKeyCreated
    {
        /// <summary>
        /// The ID of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The redacted value of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redacted_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string RedactedValue { get; set; } = default!;

        /// <summary>
        /// The expiration datetime of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The creation datetime of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The last update datetime of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The last active datetime of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_active_at")]
        public global::System.DateTime? LastActiveAt { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: api_key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The scope of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public global::System.Collections.Generic.IList<global::G.Scope>? Scope { get; set; }

        /// <summary>
        /// The value of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the API key
        /// </param>
        /// <param name="name">
        /// The name of the API key
        /// </param>
        /// <param name="redactedValue">
        /// The redacted value of the API key
        /// </param>
        /// <param name="createdAt">
        /// The creation datetime of the API key
        /// </param>
        /// <param name="updatedAt">
        /// The last update datetime of the API key
        /// </param>
        /// <param name="value">
        /// The value of the API key
        /// </param>
        /// <param name="expiresAt">
        /// The expiration datetime of the API key
        /// </param>
        /// <param name="lastActiveAt">
        /// The last active datetime of the API key
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: api_key
        /// </param>
        /// <param name="scope">
        /// The scope of the API key
        /// </param>
        public ApiKeyCreated(
            string id,
            string name,
            string redactedValue,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string value,
            global::System.DateTime? expiresAt,
            global::System.DateTime? lastActiveAt,
            string? @object,
            global::System.Collections.Generic.IList<global::G.Scope>? scope)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RedactedValue = redactedValue ?? throw new global::System.ArgumentNullException(nameof(redactedValue));
            this.ExpiresAt = expiresAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastActiveAt = lastActiveAt;
            this.Object = @object;
            this.Scope = scope;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreated" /> class.
        /// </summary>
        public ApiKeyCreated()
        {
        }
    }
}