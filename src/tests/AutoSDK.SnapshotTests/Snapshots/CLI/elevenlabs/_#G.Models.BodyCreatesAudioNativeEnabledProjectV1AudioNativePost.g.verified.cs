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
        /// (Deprecated) Image URL used in the player. If not provided, default image set in the Player settings is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// (Deprecated) Whether to use small player or not. If not provided, default value set in the Player settings is used.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("small")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Small { get; set; }

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
        /// (Deprecated) Specifies for how many minutes to persist the session across page reloads. If not provided, default sessionization set in the Player settings is used.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionization")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Sessionization { get; set; }

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
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h3&amp;gt;More of your content&amp;lt;/h3&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h3&amp;gt;More of your content&amp;lt;/h3&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_convert")]
        public bool? AutoConvert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatesAudioNativeEnabledProjectV1AudioNativePost" /> class.
        /// </summary>
        /// <param name="name">
        /// Project name.
        /// </param>
        /// <param name="author">
        /// Author used in the player and inserted at the start of the uploaded article. If not provided, the default author set in the Player settings is used.
        /// </param>
        /// <param name="title">
        /// Title used in the player and inserted at the top of the uploaded article. If not provided, the default title set in the Player settings is used.
        /// </param>
        /// <param name="textColor">
        /// Text color used in the player. If not provided, default text color set in the Player settings is used.
        /// </param>
        /// <param name="backgroundColor">
        /// Background color used in the player. If not provided, default background color set in the Player settings is used.
        /// </param>
        /// <param name="voiceId">
        /// Voice ID used to voice the content. If not provided, default voice ID set in the Player settings is used.
        /// </param>
        /// <param name="modelId">
        /// TTS Model ID used in the player. If not provided, default model ID set in the Player settings is used.
        /// </param>
        /// <param name="file">
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h3&amp;gt;More of your content&amp;lt;/h3&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </param>
        /// <param name="filename">
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h3&amp;gt;More of your content&amp;lt;/h3&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreatesAudioNativeEnabledProjectV1AudioNativePost(
            string name,
            string? author,
            string? title,
            string? textColor,
            string? backgroundColor,
            string? voiceId,
            string? modelId,
            byte[]? file,
            string? filename,
            bool? autoConvert)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Author = author;
            this.Title = title;
            this.TextColor = textColor;
            this.BackgroundColor = backgroundColor;
            this.VoiceId = voiceId;
            this.ModelId = modelId;
            this.File = file;
            this.Filename = filename;
            this.AutoConvert = autoConvert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatesAudioNativeEnabledProjectV1AudioNativePost" /> class.
        /// </summary>
        public BodyCreatesAudioNativeEnabledProjectV1AudioNativePost()
        {
        }
    }
}