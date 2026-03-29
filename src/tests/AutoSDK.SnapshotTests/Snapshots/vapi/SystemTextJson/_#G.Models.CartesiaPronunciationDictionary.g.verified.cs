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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the pronunciation dictionary<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID of the user who owns this dictionary<br/>
        /// Example: user_xyz789
        /// </summary>
        /// <example>user_xyz789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Whether this dictionary is pinned for the user<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pinned { get; set; }

        /// <summary>
        /// List of text-to-pronunciation mappings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CartesiaPronunciationDictItem> Items { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the dictionary was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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