//HintName: G.Models.CreateImageToVideoRequestVeo31Fast.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestVeo31Fast
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// You may specify an image to use as the first frame of the output video, or an array with a first frame and optionally a last frame. This model does not support generating with only a last frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateImageToVideoRequestVeo31FastRatio Ratio { get; set; }

        /// <summary>
        /// Whether to generate audio for the video. Audio inclusion affects pricing.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"veo3.1_fast"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "veo3.1_fast";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo31Fast" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// You may specify an image to use as the first frame of the output video, or an array with a first frame and optionally a last frame. This model does not support generating with only a last frame.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video. Audio inclusion affects pricing.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestVeo31Fast(
            global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>> promptImage,
            global::G.CreateImageToVideoRequestVeo31FastRatio ratio,
            string? promptText,
            bool? audio,
            double? duration,
            string model = "veo3.1_fast")
        {
            this.PromptText = promptText;
            this.PromptImage = promptImage;
            this.Ratio = ratio;
            this.Audio = audio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo31Fast" /> class.
        /// </summary>
        public CreateImageToVideoRequestVeo31Fast()
        {
        }
    }
}