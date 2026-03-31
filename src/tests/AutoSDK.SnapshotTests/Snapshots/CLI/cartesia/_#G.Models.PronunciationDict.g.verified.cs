//HintName: G.Models.PronunciationDict.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary of text-to-alias mappings
    /// </summary>
    public sealed partial class PronunciationDict
    {
        /// <summary>
        /// Unique identifier for the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID of the user who owns this dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Whether this dictionary is pinned for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pinned { get; set; }

        /// <summary>
        /// List of text-to-pronunciation mappings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PronunciationDictItem> Items { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the dictionary was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDict" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the pronunciation dictionary
        /// </param>
        /// <param name="name">
        /// Name of the pronunciation dictionary
        /// </param>
        /// <param name="ownerId">
        /// ID of the user who owns this dictionary
        /// </param>
        /// <param name="pinned">
        /// Whether this dictionary is pinned for the user
        /// </param>
        /// <param name="items">
        /// List of text-to-pronunciation mappings
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the dictionary was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDict(
            string id,
            string name,
            string ownerId,
            bool pinned,
            global::System.Collections.Generic.IList<global::G.PronunciationDictItem> items,
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
        /// Initializes a new instance of the <see cref="PronunciationDict" /> class.
        /// </summary>
        public PronunciationDict()
        {
        }
    }
}