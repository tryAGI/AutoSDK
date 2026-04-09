//HintName: G.Models.ListApiKeysResponseKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API key information
    /// </summary>
    public sealed partial class ListApiKeysResponseKey
    {
        /// <summary>
        /// Unique identifier for the API key<br/>
        /// Example: abc123def456
        /// </summary>
        /// <example>abc123def456</example>
        [global::Newtonsoft.Json.JsonProperty("key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyId { get; set; } = default!;

        /// <summary>
        /// User-provided friendly name for the key<br/>
        /// Example: Production Key
        /// </summary>
        /// <example>Production Key</example>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// Scope of the API key. Only API scope keys can be managed via this API.<br/>
        /// Example: API
        /// </summary>
        /// <example>API</example>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ListApiKeysResponseKeyScopeJsonConverter))]
        public global::G.ListApiKeysResponseKeyScope Scope { get; set; }

        /// <summary>
        /// ISO8601 timestamp when the key was created<br/>
        /// Example: 2025-01-15T12:00:00Z
        /// </summary>
        /// <example>2025-01-15T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Nickname of the user who created this key (when expanded)<br/>
        /// Example: developer
        /// </summary>
        /// <example>developer</example>
        [global::Newtonsoft.Json.JsonProperty("creator_nickname")]
        public string? CreatorNickname { get; set; }

        /// <summary>
        /// Email of the user who created this key (when expanded)<br/>
        /// Example: developer@example.com
        /// </summary>
        /// <example>developer@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("creator_email")]
        public string? CreatorEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseKey" /> class.
        /// </summary>
        /// <param name="keyId">
        /// Unique identifier for the API key<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="alias">
        /// User-provided friendly name for the key<br/>
        /// Example: Production Key
        /// </param>
        /// <param name="createdAt">
        /// ISO8601 timestamp when the key was created<br/>
        /// Example: 2025-01-15T12:00:00Z
        /// </param>
        /// <param name="scope">
        /// Scope of the API key. Only API scope keys can be managed via this API.<br/>
        /// Example: API
        /// </param>
        /// <param name="creatorNickname">
        /// Nickname of the user who created this key (when expanded)<br/>
        /// Example: developer
        /// </param>
        /// <param name="creatorEmail">
        /// Email of the user who created this key (when expanded)<br/>
        /// Example: developer@example.com
        /// </param>
        public ListApiKeysResponseKey(
            string keyId,
            string alias,
            string createdAt,
            global::G.ListApiKeysResponseKeyScope scope,
            string? creatorNickname,
            string? creatorEmail)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Scope = scope;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatorNickname = creatorNickname;
            this.CreatorEmail = creatorEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseKey" /> class.
        /// </summary>
        public ListApiKeysResponseKey()
        {
        }
    }
}