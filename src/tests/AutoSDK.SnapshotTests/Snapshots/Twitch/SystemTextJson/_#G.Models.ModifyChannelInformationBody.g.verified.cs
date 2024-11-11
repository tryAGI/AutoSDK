//HintName: G.Models.ModifyChannelInformationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyChannelInformationBody
    {
        /// <summary>
        /// The ID of the game that the user plays. The game is not updated if the ID isn’t a game ID that Twitch recognizes. To unset this field, use “0” or “” (an empty string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        public string? GameId { get; set; }

        /// <summary>
        /// The user’s preferred language. Set the value to an ISO 639-1 two-letter language code (for example, _en_ for English). Set to “other” if the user’s preferred language is not a Twitch supported language. The language isn’t updated if the language code isn’t a Twitch supported language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_language")]
        public string? BroadcasterLanguage { get; set; }

        /// <summary>
        /// The title of the user’s stream. You may not set this field to an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The number of seconds you want your broadcast buffered before streaming it live. The delay helps ensure fairness during competitive play. Only users with Partner status may set this field. The maximum delay is 900 seconds (15 minutes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay")]
        public int? Delay { get; set; }

        /// <summary>
        /// A list of channel-defined tags to apply to the channel. To remove all tags from the channel, set tags to an empty array. Tags help identify the content that the channel streams. [Learn More](https://help.twitch.tv/s/article/guide-to-tags)  <br/>
        ///   <br/>
        /// A channel may specify a maximum of 10 tags. Each tag is limited to a maximum of 25 characters and may not be an empty string or contain spaces or special characters. Tags are case insensitive. For readability, consider using camelCasing or PascalCasing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// List of labels that should be set as the Channel’s CCLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_classification_labels")]
        public global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabel>? ContentClassificationLabels { get; set; }

        /// <summary>
        /// Boolean flag indicating if the channel has branded content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_branded_content")]
        public bool? IsBrandedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannelInformationBody" /> class.
        /// </summary>
        /// <param name="gameId">
        /// The ID of the game that the user plays. The game is not updated if the ID isn’t a game ID that Twitch recognizes. To unset this field, use “0” or “” (an empty string).
        /// </param>
        /// <param name="broadcasterLanguage">
        /// The user’s preferred language. Set the value to an ISO 639-1 two-letter language code (for example, _en_ for English). Set to “other” if the user’s preferred language is not a Twitch supported language. The language isn’t updated if the language code isn’t a Twitch supported language.
        /// </param>
        /// <param name="title">
        /// The title of the user’s stream. You may not set this field to an empty string.
        /// </param>
        /// <param name="delay">
        /// The number of seconds you want your broadcast buffered before streaming it live. The delay helps ensure fairness during competitive play. Only users with Partner status may set this field. The maximum delay is 900 seconds (15 minutes).
        /// </param>
        /// <param name="tags">
        /// A list of channel-defined tags to apply to the channel. To remove all tags from the channel, set tags to an empty array. Tags help identify the content that the channel streams. [Learn More](https://help.twitch.tv/s/article/guide-to-tags)  <br/>
        ///   <br/>
        /// A channel may specify a maximum of 10 tags. Each tag is limited to a maximum of 25 characters and may not be an empty string or contain spaces or special characters. Tags are case insensitive. For readability, consider using camelCasing or PascalCasing.
        /// </param>
        /// <param name="contentClassificationLabels">
        /// List of labels that should be set as the Channel’s CCLs.
        /// </param>
        /// <param name="isBrandedContent">
        /// Boolean flag indicating if the channel has branded content.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModifyChannelInformationBody(
            string? gameId,
            string? broadcasterLanguage,
            string? title,
            int? delay,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabel>? contentClassificationLabels,
            bool? isBrandedContent)
        {
            this.GameId = gameId;
            this.BroadcasterLanguage = broadcasterLanguage;
            this.Title = title;
            this.Delay = delay;
            this.Tags = tags;
            this.ContentClassificationLabels = contentClassificationLabels;
            this.IsBrandedContent = isBrandedContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannelInformationBody" /> class.
        /// </summary>
        public ModifyChannelInformationBody()
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
        public static global::G.ModifyChannelInformationBody? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ModifyChannelInformationBody),
                jsonSerializerContext) as global::G.ModifyChannelInformationBody;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ModifyChannelInformationBody? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ModifyChannelInformationBody>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ModifyChannelInformationBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ModifyChannelInformationBody),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ModifyChannelInformationBody;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ModifyChannelInformationBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ModifyChannelInformationBody?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}