//HintName: G.Models.PublicCloneVoiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicCloneVoiceRequest
    {
        /// <summary>
        /// 音频格式支持：wav、mp3、ogg、m4a、aac、pcm，其中pcm仅支持24k 单通道目前限制单文件上传最大10MB，每次最多上传1个音频文件
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.PropertiesAudio? Audio { get; set; }

        /// <summary>
        /// 传入文件的音频格式，例如 pcm, m4a, mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFormat { get; set; }

        /// <summary>
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 如果传入会基于该文本生成预览音频，否则使用默认的文本"你好，我是你的专属AI克隆声音，希望未来可以一起好好相处哦"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_text")]
        public string? PreviewText { get; set; }

        /// <summary>
        /// 克隆音色保存的空间，默认在个人空间
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space_id")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 可以让用户按照该文本念诵，服务会对比音频与该文本的差异。若差异过大会返回1109 WERError
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 如果有，则使用此 voice_id 进行训练覆盖，否则使用新的 voice_id 进行训练
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 音色名
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCloneVoiceRequest" /> class.
        /// </summary>
        /// <param name="audioFormat">
        /// 传入文件的音频格式，例如 pcm, m4a, mp3
        /// </param>
        /// <param name="file">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        /// <param name="filename">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        /// <param name="voiceName">
        /// 音色名
        /// </param>
        /// <param name="audio">
        /// 音频格式支持：wav、mp3、ogg、m4a、aac、pcm，其中pcm仅支持24k 单通道目前限制单文件上传最大10MB，每次最多上传1个音频文件
        /// </param>
        /// <param name="language"></param>
        /// <param name="previewText">
        /// 如果传入会基于该文本生成预览音频，否则使用默认的文本"你好，我是你的专属AI克隆声音，希望未来可以一起好好相处哦"
        /// </param>
        /// <param name="spaceId">
        /// 克隆音色保存的空间，默认在个人空间
        /// </param>
        /// <param name="text">
        /// 可以让用户按照该文本念诵，服务会对比音频与该文本的差异。若差异过大会返回1109 WERError
        /// </param>
        /// <param name="voiceId">
        /// 如果有，则使用此 voice_id 进行训练覆盖，否则使用新的 voice_id 进行训练
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicCloneVoiceRequest(
            string audioFormat,
            byte[] file,
            string filename,
            string voiceName,
            global::G.PropertiesAudio? audio,
            string? language,
            string? previewText,
            string? spaceId,
            string? text,
            string? voiceId)
        {
            this.Audio = audio;
            this.AudioFormat = audioFormat ?? throw new global::System.ArgumentNullException(nameof(audioFormat));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Language = language;
            this.PreviewText = previewText;
            this.SpaceId = spaceId;
            this.Text = text;
            this.VoiceId = voiceId;
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCloneVoiceRequest" /> class.
        /// </summary>
        public PublicCloneVoiceRequest()
        {
        }
    }
}