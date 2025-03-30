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
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The image of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public string Image { get; set; } = default!;

        /// <summary>
        /// The author of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public string Author { get; set; } = default!;

        /// <summary>
        /// Whether the project is small.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("small", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Small { get; set; } = default!;

        /// <summary>
        /// The text color of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_color", Required = global::Newtonsoft.Json.Required.Always)]
        public string TextColor { get; set; } = default!;

        /// <summary>
        /// The background color of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_color", Required = global::Newtonsoft.Json.Required.Always)]
        public string BackgroundColor { get; set; } = default!;

        /// <summary>
        /// The sessionization of the project. Specifies for how many minutes to persist the session across page reloads.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionization", Required = global::Newtonsoft.Json.Required.Always)]
        public int Sessionization { get; set; } = default!;

        /// <summary>
        /// The path of the audio file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_path")]
        public string? AudioPath { get; set; }

        /// <summary>
        /// The URL of the audio file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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