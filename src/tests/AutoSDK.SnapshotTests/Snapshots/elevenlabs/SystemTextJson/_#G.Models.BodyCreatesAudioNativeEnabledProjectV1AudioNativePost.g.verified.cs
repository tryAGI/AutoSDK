//HintName: G.Models.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatesAudioNativeEnabledProjectV1AudioNativePost
    {
        /// <summary>
        /// Project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Image URL used in the player. If not provided, default image set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Author used in the player and inserted at the start of the uploaded article. If not provided, the default author set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Title used in the player and inserted at the top of the uploaded article. If not provided, the default title set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Whether to use small player or not. If not provided, default value set in the Player settings is used.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("small")]
        public bool? Small { get; set; } = false;

        /// <summary>
        /// Text color used in the player. If not provided, default text color set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// Background color used in the player. If not provided, default background color set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Specifies for how many minutes to persist the session across page reloads. If not provided, default sessionization set in the Player settings is used.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionization")]
        public int? Sessionization { get; set; } = 0;

        /// <summary>
        /// Voice ID used to voice the content. If not provided, default voice ID set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// TTS Model ID used in the player. If not provided, default model ID set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_convert")]
        public bool? AutoConvert { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost),
                jsonSerializerContext) as global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost>(
                json,
                jsonSerializerOptions);
        }

    }
}