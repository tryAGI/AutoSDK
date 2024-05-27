//HintName: G.Models.Game.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Game
    {
        /// <summary>
        /// An ID that identifies the category or game.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The category’s or game’s name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A URL to the category’s or game’s box art. You must replace the `{width}x{height}` placeholder with the size of image you want.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box_art_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BoxArtUrl { get; set; }

        /// <summary>
        /// The ID that [IGDB](https://www.igdb.com/) uses to identify this game. If the IGDB ID is not available to Twitch, this field is set to an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("igdb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IgdbId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}