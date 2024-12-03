//HintName: G.Models.Category.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Category
    {
        /// <summary>
        /// A URL to an image of the game’s box art or streaming category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("box_art_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BoxArtUrl { get; set; } = default!;

        /// <summary>
        /// The name of the game or category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// An ID that uniquely identifies the game or category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="boxArtUrl">
        /// A URL to an image of the game’s box art or streaming category.
        /// </param>
        /// <param name="name">
        /// The name of the game or category.
        /// </param>
        /// <param name="id">
        /// An ID that uniquely identifies the game or category.
        /// </param>
        public Category(
            string boxArtUrl,
            string name,
            string id)
        {
            this.BoxArtUrl = boxArtUrl ?? throw new global::System.ArgumentNullException(nameof(boxArtUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        public Category()
        {
        }
    }
}