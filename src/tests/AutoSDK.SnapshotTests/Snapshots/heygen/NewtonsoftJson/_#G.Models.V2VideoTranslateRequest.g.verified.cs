//HintName: G.Models.V2VideoTranslateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoTranslateRequest
    {
        /// <summary>
        /// Example: English - American Accent
        /// </summary>
        /// <example>English - American Accent</example>
        [global::Newtonsoft.Json.JsonProperty("output_language")]
        public string? OutputLanguage { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("speaker_num")]
        public double? SpeakerNum { get; set; }

        /// <summary>
        /// Example: My Title
        /// </summary>
        /// <example>My Title</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("translate_audio_only")]
        public bool? TranslateAudioOnly { get; set; }

        /// <summary>
        /// Example: https://static.heygen.ai/heygen/asset/originalnew.mp4
        /// </summary>
        /// <example>https://static.heygen.ai/heygen/asset/originalnew.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoTranslateRequest" /> class.
        /// </summary>
        /// <param name="outputLanguage">
        /// Example: English - American Accent
        /// </param>
        /// <param name="speakerNum">
        /// Example: 1
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="translateAudioOnly">
        /// Example: false
        /// </param>
        /// <param name="videoUrl">
        /// Example: https://static.heygen.ai/heygen/asset/originalnew.mp4
        /// </param>
        public V2VideoTranslateRequest(
            string? outputLanguage,
            double? speakerNum,
            string? title,
            bool? translateAudioOnly,
            string? videoUrl)
        {
            this.OutputLanguage = outputLanguage;
            this.SpeakerNum = speakerNum;
            this.Title = title;
            this.TranslateAudioOnly = translateAudioOnly;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoTranslateRequest" /> class.
        /// </summary>
        public V2VideoTranslateRequest()
        {
        }
    }
}