//HintName: G.Models.CreateImageToVideoRequestVeo3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestVeo3
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo3PromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo3PromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        /// <default>8</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double Duration { get; set; } = 8;

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageToVideoRequestVeo3RatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateImageToVideoRequestVeo3Ratio Ratio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"veo3"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "veo3";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo3" /> class.
        /// </summary>
        /// <param name="promptImage"></param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestVeo3(
            global::G.AnyOf<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo3PromptImagePromptImage>> promptImage,
            global::G.CreateImageToVideoRequestVeo3Ratio ratio,
            string? promptText,
            double duration = 8,
            string model = "veo3")
        {
            this.PromptText = promptText;
            this.PromptImage = promptImage;
            this.Duration = duration;
            this.Ratio = ratio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo3" /> class.
        /// </summary>
        public CreateImageToVideoRequestVeo3()
        {
        }
    }
}