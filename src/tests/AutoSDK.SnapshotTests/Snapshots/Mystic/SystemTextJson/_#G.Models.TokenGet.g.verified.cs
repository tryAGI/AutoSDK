//HintName: G.Models.TokenGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API token representation when returned from an API call.
    /// </summary>
    public sealed partial class TokenGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        public global::System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="expiresAt"></param>
        /// <param name="lastUsed"></param>
        /// <param name="isActive"></param>
        /// <param name="isEnabled"></param>
        /// <param name="teamId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TokenGet(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string value,
            string name,
            bool isActive,
            bool isEnabled,
            global::System.DateTime? expiresAt,
            global::System.DateTime? lastUsed,
            string? teamId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsActive = isActive;
            this.IsEnabled = isEnabled;
            this.ExpiresAt = expiresAt;
            this.LastUsed = lastUsed;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenGet" /> class.
        /// </summary>
        public TokenGet()
        {
        }
    }
}