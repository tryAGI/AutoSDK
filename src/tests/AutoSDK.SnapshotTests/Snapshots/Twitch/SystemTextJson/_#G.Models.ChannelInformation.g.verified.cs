//HintName: G.Models.ChannelInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelInformation
    {
        /// <summary>
        /// An ID that uniquely identifies the broadcaster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The broadcaster’s preferred language. The value is an ISO 639-1 two-letter language code (for example, _en_ for English). The value is set to “other” if the language is not a Twitch supported language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLanguage { get; set; }

        /// <summary>
        /// The name of the game that the broadcaster is playing or last played. The value is an empty string if the broadcaster has never played a game.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameName { get; set; }

        /// <summary>
        /// An ID that uniquely identifies the game that the broadcaster is playing or last played. The value is an empty string if the broadcaster has never played a game.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameId { get; set; }

        /// <summary>
        /// The title of the stream that the broadcaster is currently streaming or last streamed. The value is an empty string if the broadcaster has never streamed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The value of the broadcaster’s stream delay setting, in seconds. This field’s value defaults to zero unless 1) the request specifies a user access token, 2) the ID in the _broadcaster\_id_ query parameter matches the user ID in the access token, and 3) the broadcaster has partner status and they set a non-zero stream delay value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Delay { get; set; }

        /// <summary>
        /// The tags applied to the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// The CCLs applied to the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_classification_labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ContentClassificationLabels { get; set; }

        /// <summary>
        /// Boolean flag indicating if the channel has branded content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_branded_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBrandedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelInformation" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// An ID that uniquely identifies the broadcaster.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="broadcasterLanguage">
        /// The broadcaster’s preferred language. The value is an ISO 639-1 two-letter language code (for example, _en_ for English). The value is set to “other” if the language is not a Twitch supported language.
        /// </param>
        /// <param name="gameName">
        /// The name of the game that the broadcaster is playing or last played. The value is an empty string if the broadcaster has never played a game.
        /// </param>
        /// <param name="gameId">
        /// An ID that uniquely identifies the game that the broadcaster is playing or last played. The value is an empty string if the broadcaster has never played a game.
        /// </param>
        /// <param name="title">
        /// The title of the stream that the broadcaster is currently streaming or last streamed. The value is an empty string if the broadcaster has never streamed.
        /// </param>
        /// <param name="delay">
        /// The value of the broadcaster’s stream delay setting, in seconds. This field’s value defaults to zero unless 1) the request specifies a user access token, 2) the ID in the _broadcaster\_id_ query parameter matches the user ID in the access token, and 3) the broadcaster has partner status and they set a non-zero stream delay value.
        /// </param>
        /// <param name="tags">
        /// The tags applied to the channel.
        /// </param>
        /// <param name="contentClassificationLabels">
        /// The CCLs applied to the channel.
        /// </param>
        /// <param name="isBrandedContent">
        /// Boolean flag indicating if the channel has branded content.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChannelInformation(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string broadcasterLanguage,
            string gameName,
            string gameId,
            string title,
            int delay,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Collections.Generic.IList<string> contentClassificationLabels,
            bool isBrandedContent)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.BroadcasterLanguage = broadcasterLanguage ?? throw new global::System.ArgumentNullException(nameof(broadcasterLanguage));
            this.GameName = gameName ?? throw new global::System.ArgumentNullException(nameof(gameName));
            this.GameId = gameId ?? throw new global::System.ArgumentNullException(nameof(gameId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Delay = delay;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.ContentClassificationLabels = contentClassificationLabels ?? throw new global::System.ArgumentNullException(nameof(contentClassificationLabels));
            this.IsBrandedContent = isBrandedContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelInformation" /> class.
        /// </summary>
        public ChannelInformation()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ChannelInformation? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ChannelInformation),
                jsonSerializerContext) as global::G.ChannelInformation;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ChannelInformation? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChannelInformation>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ChannelInformation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ChannelInformation),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ChannelInformation;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ChannelInformation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ChannelInformation?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}