//HintName: G.Models.CartesiaPronunciationDictionary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartesiaPronunciationDictionary
    {
        /// <summary>
        /// Unique identifier for the pronunciation dictionary<br/>
        /// Example: dict_abc123
        /// </summary>
        /// <example>dict_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the pronunciation dictionary<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// ID of the user who owns this dictionary<br/>
        /// Example: user_xyz789
        /// </summary>
        /// <example>user_xyz789</example>
        [global::Newtonsoft.Json.JsonProperty("ownerId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// Whether this dictionary is pinned for the user<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("pinned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Pinned { get; set; } = default!;

        /// <summary>
        /// List of text-to-pronunciation mappings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CartesiaPronunciationDictItem> Items { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp of when the dictionary was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaPronunciationDictionary" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the pronunciation dictionary<br/>
        /// Example: dict_abc123
        /// </param>
        /// <param name="name">
        /// Name of the pronunciation dictionary<br/>
        /// Example: My Dictionary
        /// </param>
        /// <param name="ownerId">
        /// ID of the user who owns this dictionary<br/>
        /// Example: user_xyz789
        /// </param>
        /// <param name="pinned">
        /// Whether this dictionary is pinned for the user<br/>
        /// Example: false
        /// </param>
        /// <param name="items">
        /// List of text-to-pronunciation mappings
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the dictionary was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        public CartesiaPronunciationDictionary(
            string id,
            string name,
            string ownerId,
            bool pinned,
            global::System.Collections.Generic.IList<global::G.CartesiaPronunciationDictItem> items,
            string createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Pinned = pinned;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaPronunciationDictionary" /> class.
        /// </summary>
        public CartesiaPronunciationDictionary()
        {
        }
    }
}