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

        /// <summary>
        /// Initializes a new instance of the <see cref="Game" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the category or game.
        /// </param>
        /// <param name="name">
        /// The category’s or game’s name.
        /// </param>
        /// <param name="boxArtUrl">
        /// A URL to the category’s or game’s box art. You must replace the `{width}x{height}` placeholder with the size of image you want.
        /// </param>
        /// <param name="igdbId">
        /// The ID that [IGDB](https://www.igdb.com/) uses to identify this game. If the IGDB ID is not available to Twitch, this field is set to an empty string.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Game(
            string id,
            string name,
            string boxArtUrl,
            string igdbId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.BoxArtUrl = boxArtUrl ?? throw new global::System.ArgumentNullException(nameof(boxArtUrl));
            this.IgdbId = igdbId ?? throw new global::System.ArgumentNullException(nameof(igdbId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Game" /> class.
        /// </summary>
        public Game()
        {
        }
    }
}