//HintName: G.Models.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The newly generated API key for this project
    /// </summary>
    public sealed partial class PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey
    {
        /// <summary>
        /// Unique identifier for the API key<br/>
        /// Example: 01H4DKRF5SMP7NQCA3BWT0JYB6
        /// </summary>
        /// <example>01H4DKRF5SMP7NQCA3BWT0JYB6</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the API key<br/>
        /// Example: epic_avatar
        /// </summary>
        /// <example>epic_avatar</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The newly generated API key value<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </summary>
        /// <example>ak_a1b2c3d4e5f6g7h8i9j0</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// ISO timestamp when the API key was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </summary>
        /// <example>2023-05-16T14:30:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the API key<br/>
        /// Example: 01H4DKRF5SMP7NQCA3BWT0JYB6
        /// </param>
        /// <param name="name">
        /// Name of the API key<br/>
        /// Example: epic_avatar
        /// </param>
        /// <param name="key">
        /// The newly generated API key value<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="createdAt">
        /// ISO timestamp when the API key was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </param>
        public PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey(
            string id,
            string name,
            string key,
            string createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey" /> class.
        /// </summary>
        public PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey()
        {
        }
    }
}