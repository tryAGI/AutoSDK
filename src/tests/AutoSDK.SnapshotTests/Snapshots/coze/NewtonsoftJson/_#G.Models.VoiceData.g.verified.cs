//HintName: G.Models.VoiceData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceData
    {
        /// <summary>
        /// 唯一id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 音色语种code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 音色语种名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_name")]
        public string? LanguageName { get; set; }

        /// <summary>
        /// 音色名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 预览音色内容
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_audio")]
        public string? PreviewAudio { get; set; }

        /// <summary>
        /// 预览文本内容
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_text")]
        public string? PreviewText { get; set; }

        /// <summary>
        /// 音色 style_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style_id")]
        public string? StyleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceData" /> class.
        /// </summary>
        /// <param name="id">
        /// 唯一id
        /// </param>
        /// <param name="languageCode">
        /// 音色语种code
        /// </param>
        /// <param name="languageName">
        /// 音色语种名称
        /// </param>
        /// <param name="name">
        /// 音色名称
        /// </param>
        /// <param name="previewAudio">
        /// 预览音色内容
        /// </param>
        /// <param name="previewText">
        /// 预览文本内容
        /// </param>
        /// <param name="styleId">
        /// 音色 style_id
        /// </param>
        public VoiceData(
            string? id,
            string? languageCode,
            string? languageName,
            string? name,
            string? previewAudio,
            string? previewText,
            string? styleId)
        {
            this.Id = id;
            this.LanguageCode = languageCode;
            this.LanguageName = languageName;
            this.Name = name;
            this.PreviewAudio = previewAudio;
            this.PreviewText = previewText;
            this.StyleId = styleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceData" /> class.
        /// </summary>
        public VoiceData()
        {
        }
    }
}