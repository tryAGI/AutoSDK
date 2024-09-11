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
        [global::Newtonsoft.Json.JsonProperty("output_language")]
        public string? OutputLanguage { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_num")]
        public double SpeakerNum { get; set; }

        /// <summary>
        /// Example: My Title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translate_audio_only")]
        public bool TranslateAudioOnly { get; set; }

        /// <summary>
        /// Example: https://static.heygen.ai/heygen/asset/originalnew.mp4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}