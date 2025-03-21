//HintName: G.Models.AdminApiKeyOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminApiKeyOwner
    {
        /// <summary>
        /// Example: service_account
        /// </summary>
        /// <example>service_account</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: sa_456
        /// </summary>
        /// <example>sa_456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: My Service Account
        /// </summary>
        /// <example>My Service Account</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: 1711471533L
        /// </summary>
        /// <example>1711471533L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Example: member
        /// </summary>
        /// <example>member</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyOwner" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: service_account
        /// </param>
        /// <param name="id">
        /// Example: sa_456
        /// </param>
        /// <param name="name">
        /// Example: My Service Account
        /// </param>
        /// <param name="createdAt">
        /// Example: 1711471533L
        /// </param>
        /// <param name="role">
        /// Example: member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminApiKeyOwner(
            string? type,
            string? id,
            string? name,
            long? createdAt,
            string? role)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyOwner" /> class.
        /// </summary>
        public AdminApiKeyOwner()
        {
        }
    }
}