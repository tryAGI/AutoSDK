//HintName: G.Models.OpenAPIVoiceData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIVoiceData
    {
        /// <summary>
        /// 剩余训练次数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("available_training_times")]
        public int? AvailableTrainingTimes { get; set; }

        /// <summary>
        /// 创建时间unix时间戳
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 是否系统音色
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_system_voice")]
        public bool? IsSystemVoice { get; set; }

        /// <summary>
        /// 语言代号
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 语言名
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_name")]
        public string? LanguageName { get; set; }

        /// <summary>
        /// 模型类型
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// 音色名
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 音色预览音频
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_audio")]
        public string? PreviewAudio { get; set; }

        /// <summary>
        /// 音色预览文本
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_text")]
        public string? PreviewText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAPIVoiceStateJsonConverter))]
        public global::G.OpenAPIVoiceState? State { get; set; }

        /// <summary>
        /// 支持的情感列表
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("support_emotions")]
        public global::System.Collections.Generic.IList<global::G.EmotionInfo>? SupportEmotions { get; set; }

        /// <summary>
        /// 更新时间unix时间戳
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// 唯一音色代号
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIVoiceData" /> class.
        /// </summary>
        /// <param name="availableTrainingTimes">
        /// 剩余训练次数
        /// </param>
        /// <param name="createTime">
        /// 创建时间unix时间戳
        /// </param>
        /// <param name="isSystemVoice">
        /// 是否系统音色
        /// </param>
        /// <param name="languageCode">
        /// 语言代号
        /// </param>
        /// <param name="languageName">
        /// 语言名
        /// </param>
        /// <param name="modelType">
        /// 模型类型
        /// </param>
        /// <param name="name">
        /// 音色名
        /// </param>
        /// <param name="previewAudio">
        /// 音色预览音频
        /// </param>
        /// <param name="previewText">
        /// 音色预览文本
        /// </param>
        /// <param name="state"></param>
        /// <param name="supportEmotions">
        /// 支持的情感列表
        /// </param>
        /// <param name="updateTime">
        /// 更新时间unix时间戳
        /// </param>
        /// <param name="voiceId">
        /// 唯一音色代号
        /// </param>
        public OpenAPIVoiceData(
            int? availableTrainingTimes,
            int? createTime,
            bool? isSystemVoice,
            string? languageCode,
            string? languageName,
            string? modelType,
            string? name,
            string? previewAudio,
            string? previewText,
            global::G.OpenAPIVoiceState? state,
            global::System.Collections.Generic.IList<global::G.EmotionInfo>? supportEmotions,
            int? updateTime,
            string? voiceId)
        {
            this.AvailableTrainingTimes = availableTrainingTimes;
            this.CreateTime = createTime;
            this.IsSystemVoice = isSystemVoice;
            this.LanguageCode = languageCode;
            this.LanguageName = languageName;
            this.ModelType = modelType;
            this.Name = name;
            this.PreviewAudio = previewAudio;
            this.PreviewText = previewText;
            this.State = state;
            this.SupportEmotions = supportEmotions;
            this.UpdateTime = updateTime;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIVoiceData" /> class.
        /// </summary>
        public OpenAPIVoiceData()
        {
        }
    }
}