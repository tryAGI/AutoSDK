//HintName: G.Models.PublicAudioSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAudioSpeechRequest
    {
        /// <summary>
        /// 语音合成辅助信息
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_texts")]
        public string? ContextTexts { get; set; }

        /// <summary>
        /// 情感，可选值 [none,happy,angry,sad,neutral]，默认 none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PublicAudioSpeechRequestEmotionJsonConverter))]
        public global::G.PublicAudioSpeechRequestEmotion? Emotion { get; set; }

        /// <summary>
        /// 情绪值，[1,5]，默认 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion_scale")]
        public double? EmotionScale { get; set; }

        /// <summary>
        /// 必选，合成语音的文本，长度限制 1024 字节（UTF-8编码）。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// 音量，[-50,100]，默认 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_rate")]
        public int? LoudnessRate { get; set; }

        /// <summary>
        /// 音频编码格式，wav / pcm / ogg_opus / mp3，默认为 mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PublicAudioSpeechRequestResponseFormatJsonConverter))]
        public global::G.PublicAudioSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 采样率，可选值 [8000,16000,22050,24000,32000,44100,48000]，默认 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 语速，[0.2,3]，默认为1，通常保留一位小数即可
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// 必选，音色id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAudioSpeechRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// 必选，合成语音的文本，长度限制 1024 字节（UTF-8编码）。
        /// </param>
        /// <param name="voiceId">
        /// 必选，音色id
        /// </param>
        /// <param name="contextTexts">
        /// 语音合成辅助信息
        /// </param>
        /// <param name="emotion">
        /// 情感，可选值 [none,happy,angry,sad,neutral]，默认 none
        /// </param>
        /// <param name="emotionScale">
        /// 情绪值，[1,5]，默认 4
        /// </param>
        /// <param name="loudnessRate">
        /// 音量，[-50,100]，默认 0
        /// </param>
        /// <param name="responseFormat">
        /// 音频编码格式，wav / pcm / ogg_opus / mp3，默认为 mp3
        /// </param>
        /// <param name="sampleRate">
        /// 采样率，可选值 [8000,16000,22050,24000,32000,44100,48000]，默认 24000
        /// </param>
        /// <param name="speed">
        /// 语速，[0.2,3]，默认为1，通常保留一位小数即可
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAudioSpeechRequest(
            string input,
            string voiceId,
            string? contextTexts,
            global::G.PublicAudioSpeechRequestEmotion? emotion,
            double? emotionScale,
            int? loudnessRate,
            global::G.PublicAudioSpeechRequestResponseFormat? responseFormat,
            int? sampleRate,
            double? speed)
        {
            this.ContextTexts = contextTexts;
            this.Emotion = emotion;
            this.EmotionScale = emotionScale;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.LoudnessRate = loudnessRate;
            this.ResponseFormat = responseFormat;
            this.SampleRate = sampleRate;
            this.Speed = speed;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAudioSpeechRequest" /> class.
        /// </summary>
        public PublicAudioSpeechRequest()
        {
        }
    }
}