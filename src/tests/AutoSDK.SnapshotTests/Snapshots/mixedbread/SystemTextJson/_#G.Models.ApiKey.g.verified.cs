//HintName: G.Models.ApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for an API key.
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// The ID of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The redacted value of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedValue { get; set; }

        /// <summary>
        /// The expiration datetime of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The creation datetime of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update datetime of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The last active datetime of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active_at")]
        public global::System.DateTime? LastActiveAt { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: api_key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The scope of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<global::G.Scope>? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKey(
            string id,
            string name,
            string redactedValue,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }
    }
}