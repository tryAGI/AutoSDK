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
        /// Example: 1711471533L
        /// </summary>
        /// <example>1711471533L</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Example: sa_456
        /// </summary>
        /// <example>sa_456</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: My Service Account
        /// </summary>
        /// <example>My Service Account</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: member
        /// </summary>
        /// <example>member</example>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Example: service_account
        /// </summary>
        /// <example>service_account</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyOwner" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Example: 1711471533L
        /// </param>
        /// <param name="id">
        /// Example: sa_456
        /// </param>
        /// <param name="name">
        /// Example: My Service Account
        /// </param>
        /// <param name="role">
        /// Example: member
        /// </param>
        /// <param name="type">
        /// Example: service_account
        /// </param>
        public AdminApiKeyOwner(
            long? createdAt,
            string? id,
            string? name,
            string? role,
            string? type)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Name = name;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyOwner" /> class.
        /// </summary>
        public AdminApiKeyOwner()
        {
        }
    }
}