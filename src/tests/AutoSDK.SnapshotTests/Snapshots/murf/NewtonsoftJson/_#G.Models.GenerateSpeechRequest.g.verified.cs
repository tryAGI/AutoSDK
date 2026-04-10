//HintName: G.Models.GenerateSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSpeechRequest
    {
        /// <summary>
        /// This parameter allows specifying the duration (in seconds) for the generated audio. If the value is 0, this parameter will be ignored. Only available for Gen2 model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioDuration")]
        public double? AudioDuration { get; set; }

        /// <summary>
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channelType")]
        public string? ChannelType { get; set; }

        /// <summary>
        /// Set to true to receive audio in response as a Base64 encoded string instead of a url. This enables zero retention of audio data on Murf's servers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encodeAsBase64")]
        public bool? EncodeAsBase64 { get; set; }

        /// <summary>
        /// Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW, PCM, OGG<br/>
        /// Default Value: WAV
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Valid values: GEN2. Audio will be generated using the new and advanced GEN2 model. Outputs from GEN2 sound more natural and high-quality compared to earlier models.<br/>
        /// Default Value: GEN2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelVersion")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerateSpeechRequestModelVersionJsonConverter))]
        public global::G.GenerateSpeechRequestModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.<br/>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multiNativeLocale")]
        public string? MultiNativeLocale { get; set; }

        /// <summary>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Pitch of the voiceover
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pitch")]
        public int? Pitch { get; set; }

        /// <summary>
        /// An object used to define custom pronunciations. <br/>
        ///  Example 1: {"live":{"type": "IPA", "pronunciation": "laɪv"}}. <br/>
        ///  Example 2: {"2022":{"type": "SAY_AS", "pronunciation": "twenty twenty two"}}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictionary")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PronunciationDetail>? PronunciationDictionary { get; set; }

        /// <summary>
        /// Speed of the voiceover
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// Valid values are 8000, 24000, 44100, 48000<br/>
        /// Default Value: 44100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampleRate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// The voice style to be used for voiceover generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public string? Style { get; set; }

        /// <summary>
        /// The text that is to be synthesised. e.g. 'Hello there [pause 1s] friend'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variation")]
        public int? Variation { get; set; }

        /// <summary>
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// If set to true, the word durations in response will return words as the original input text. (English only)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wordDurationsAsOriginalText")]
        public bool? WordDurationsAsOriginalText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that is to be synthesised. e.g. 'Hello there [pause 1s] friend'
        /// </param>
        /// <param name="voiceId">
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </param>
        /// <param name="audioDuration">
        /// This parameter allows specifying the duration (in seconds) for the generated audio. If the value is 0, this parameter will be ignored. Only available for Gen2 model.
        /// </param>
        /// <param name="channelType">
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </param>
        /// <param name="encodeAsBase64">
        /// Set to true to receive audio in response as a Base64 encoded string instead of a url. This enables zero retention of audio data on Murf's servers.
        /// </param>
        /// <param name="format">
        /// Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW, PCM, OGG<br/>
        /// Default Value: WAV
        /// </param>
        /// <param name="modelVersion">
        /// Valid values: GEN2. Audio will be generated using the new and advanced GEN2 model. Outputs from GEN2 sound more natural and high-quality compared to earlier models.<br/>
        /// Default Value: GEN2
        /// </param>
        /// <param name="multiNativeLocale">
        /// This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.<br/>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="locale">
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="pitch">
        /// Pitch of the voiceover
        /// </param>
        /// <param name="pronunciationDictionary">
        /// An object used to define custom pronunciations. <br/>
        ///  Example 1: {"live":{"type": "IPA", "pronunciation": "laɪv"}}. <br/>
        ///  Example 2: {"2022":{"type": "SAY_AS", "pronunciation": "twenty twenty two"}}
        /// </param>
        /// <param name="rate">
        /// Speed of the voiceover
        /// </param>
        /// <param name="sampleRate">
        /// Valid values are 8000, 24000, 44100, 48000<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="style">
        /// The voice style to be used for voiceover generation.
        /// </param>
        /// <param name="variation">
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="wordDurationsAsOriginalText">
        /// If set to true, the word durations in response will return words as the original input text. (English only)<br/>
        /// Default Value: false
        /// </param>
        public GenerateSpeechRequest(
            string text,
            string voiceId,
            double? audioDuration,
            string? channelType,
            bool? encodeAsBase64,
            string? format,
            global::G.GenerateSpeechRequestModelVersion? modelVersion,
            string? multiNativeLocale,
            string? locale,
            int? pitch,
            global::System.Collections.Generic.Dictionary<string, global::G.PronunciationDetail>? pronunciationDictionary,
            int? rate,
            double? sampleRate,
            string? style,
            int? variation,
            bool? wordDurationsAsOriginalText)
        {
            this.AudioDuration = audioDuration;
            this.ChannelType = channelType;
            this.EncodeAsBase64 = encodeAsBase64;
            this.Format = format;
            this.ModelVersion = modelVersion;
            this.MultiNativeLocale = multiNativeLocale;
            this.Locale = locale;
            this.Pitch = pitch;
            this.PronunciationDictionary = pronunciationDictionary;
            this.Rate = rate;
            this.SampleRate = sampleRate;
            this.Style = style;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Variation = variation;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.WordDurationsAsOriginalText = wordDurationsAsOriginalText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechRequest" /> class.
        /// </summary>
        public GenerateSpeechRequest()
        {
        }
    }
}