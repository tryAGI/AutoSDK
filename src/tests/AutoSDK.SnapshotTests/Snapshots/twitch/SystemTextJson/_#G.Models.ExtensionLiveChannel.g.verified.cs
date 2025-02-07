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
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The name of the category or game being streamed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameName { get; set; }

        /// <summary>
        /// The ID of the category or game being streamed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameId { get; set; }

        /// <summary>
        /// The title of the broadcaster’s stream. May be an empty string if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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