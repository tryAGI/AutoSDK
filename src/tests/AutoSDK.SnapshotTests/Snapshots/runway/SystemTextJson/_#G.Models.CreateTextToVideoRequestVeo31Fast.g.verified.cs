//HintName: G.Models.CreateTextToVideoRequestVeo31Fast.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToVideoRequestVeo31Fast
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateTextToVideoRequestVeo31FastRatio Ratio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestVeo31Fast" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
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
        public CreateTextToVideoRequestVeo31Fast(
            string promptText,
            global::G.CreateTextToVideoRequestVeo31FastRatio ratio,
            bool? audio,
            double? duration,
            string model = "veo3.1_fast")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Audio = audio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestVeo31Fast" /> class.
        /// </summary>
        public CreateTextToVideoRequestVeo31Fast()
        {
        }
    }
}