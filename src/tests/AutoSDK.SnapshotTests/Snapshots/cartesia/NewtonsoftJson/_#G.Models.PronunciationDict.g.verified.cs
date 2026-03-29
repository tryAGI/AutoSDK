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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the pronunciation dictionary
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// ID of the user who owns this dictionary
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// Whether this dictionary is pinned for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pinned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Pinned { get; set; } = default!;

        /// <summary>
        /// List of text-to-pronunciation mappings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictItem> Items { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp of when the dictionary was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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