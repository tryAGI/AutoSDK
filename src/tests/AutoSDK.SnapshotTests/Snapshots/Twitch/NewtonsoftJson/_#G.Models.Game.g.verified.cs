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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The category’s or game’s name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A URL to the category’s or game’s box art. You must replace the `{width}x{height}` placeholder with the size of image you want.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("box_art_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BoxArtUrl { get; set; } = default!;

        /// <summary>
        /// The ID that [IGDB](https://www.igdb.com/) uses to identify this game. If the IGDB ID is not available to Twitch, this field is set to an empty string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("igdb_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string IgdbId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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