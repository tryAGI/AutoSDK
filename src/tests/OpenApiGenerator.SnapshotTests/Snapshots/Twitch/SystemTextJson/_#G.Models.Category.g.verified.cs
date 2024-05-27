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
        [global::System.Text.Json.Serialization.JsonPropertyName("box_art_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BoxArtUrl { get; set; }

        /// <summary>
        /// The name of the game or category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An ID that uniquely identifies the game or category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}