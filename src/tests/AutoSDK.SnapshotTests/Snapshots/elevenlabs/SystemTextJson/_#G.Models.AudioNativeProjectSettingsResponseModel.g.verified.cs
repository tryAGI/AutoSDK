//HintName: G.Models.AudioNativeProjectSettingsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioNativeProjectSettingsResponseModel
    {
        /// <summary>
        /// The title of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The image of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// The author of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// Whether the project is small.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("small")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Small { get; set; }

        /// <summary>
        /// The text color of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextColor { get; set; }

        /// <summary>
        /// The background color of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackgroundColor { get; set; }

        /// <summary>
        /// The sessionization of the project. Specifies for how many minutes to persist the session across page reloads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sessionization { get; set; }

        /// <summary>
        /// The path of the audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        public string? AudioPath { get; set; }

        /// <summary>
        /// The URL of the audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the project.
        /// </param>
        /// <param name="image">
        /// The image of the project.
        /// </param>
        /// <param name="author">
        /// The author of the project.
        /// </param>
        /// <param name="small">
        /// Whether the project is small.
        /// </param>
        /// <param name="textColor">
        /// The text color of the project.
        /// </param>
        /// <param name="backgroundColor">
        /// The background color of the project.
        /// </param>
        /// <param name="sessionization">
        /// The sessionization of the project. Specifies for how many minutes to persist the session across page reloads.
        /// </param>
        /// <param name="audioPath">
        /// The path of the audio file.
        /// </param>
        /// <param name="audioUrl">
        /// The URL of the audio file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioNativeProjectSettingsResponseModel(
            string title,
            string image,
            string author,
            bool small,
            string textColor,
            string backgroundColor,
            int sessionization,
            string? audioPath,
            string? audioUrl)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Small = small;
            this.TextColor = textColor ?? throw new global::System.ArgumentNullException(nameof(textColor));
            this.BackgroundColor = backgroundColor ?? throw new global::System.ArgumentNullException(nameof(backgroundColor));
            this.Sessionization = sessionization;
            this.AudioPath = audioPath;
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        public AudioNativeProjectSettingsResponseModel()
        {
        }
    }
}