//HintName: G.Models.ExtensionLiveChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionLiveChannel
    {
        /// <summary>
        /// The ID of the broadcaster that is streaming live and has installed or activated the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The name of the category or game being streamed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameName { get; set; } = default!;

        /// <summary>
        /// The ID of the category or game being streamed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameId { get; set; } = default!;

        /// <summary>
        /// The title of the broadcaster’s stream. May be an empty string if not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionLiveChannel" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that is streaming live and has installed or activated the extension.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="gameName">
        /// The name of the category or game being streamed.
        /// </param>
        /// <param name="gameId">
        /// The ID of the category or game being streamed.
        /// </param>
        /// <param name="title">
        /// The title of the broadcaster’s stream. May be an empty string if not specified.
        /// </param>
        public ExtensionLiveChannel(
            string broadcasterId,
            string broadcasterName,
            string gameName,
            string gameId,
            string title)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.GameName = gameName ?? throw new global::System.ArgumentNullException(nameof(gameName));
            this.GameId = gameId ?? throw new global::System.ArgumentNullException(nameof(gameId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionLiveChannel" /> class.
        /// </summary>
        public ExtensionLiveChannel()
        {
        }
    }
}