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
        [global::Newtonsoft.Json.JsonProperty("context_texts")]
        public string? ContextTexts { get; set; }

        /// <summary>
        /// 情感，可选值 [none,happy,angry,sad,neutral]，默认 none
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion")]
        public global::G.PublicAudioSpeechRequestEmotion? Emotion { get; set; }

        /// <summary>
        /// 情绪值，[1,5]，默认 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion_scale")]
        public double? EmotionScale { get; set; }

        /// <summary>
        /// 必选，合成语音的文本，长度限制 1024 字节（UTF-8编码）。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// 音量，[-50,100]，默认 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loudness_rate")]
        public int? LoudnessRate { get; set; }

        /// <summary>
        /// 音频编码格式，wav / pcm / ogg_opus / mp3，默认为 mp3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.PublicAudioSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 采样率，可选值 [8000,16000,22050,24000,32000,44100,48000]，默认 24000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 语速，[0.2,3]，默认为1，通常保留一位小数即可
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// 必选，音色id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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