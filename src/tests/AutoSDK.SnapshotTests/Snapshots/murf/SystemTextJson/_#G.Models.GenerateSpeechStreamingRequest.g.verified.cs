//HintName: G.Models.GenerateSpeechStreamingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSpeechStreamingRequest
    {
        /// <summary>
        /// The model to use for audio output. Defaults to FALCON for all the regions except US-East. Valid values: FALCON, GEN2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelType")]
        public string? ChannelType { get; set; }

        /// <summary>
        /// Format of the generated audio file.Valid values: MP3, FLAC, WAV, ALAW, ULAW, OGG, PCM<br/>
        /// Default Value: WAV
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.<br/>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiNativeLocale")]
        public string? MultiNativeLocale { get; set; }

        /// <summary>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Pitch of the voiceover
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public int? Pitch { get; set; }

        /// <summary>
        /// An object used to define custom pronunciations. <br/>
        ///  Example 1: {"live":{"type": "IPA", "pronunciation": "laɪv"}}. <br/>
        ///  Example 2: {"2022":{"type": "SAY_AS", "pronunciation": "twenty twenty two"}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciationDictionary")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PronunciationDetail>? PronunciationDictionary { get; set; }

        /// <summary>
        /// Speed of the voiceover
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// Valid values are 8000, 16000, 24000, 44100, 48000. Defaults to 24000 for Falcon model and 44100 for Gen2 model.<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// The voice style to be used for voiceover generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// The text that is to be synthesised. e.g. 'Hello there [pause 1s] friend'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variation")]
        public int? Variation { get; set; }

        /// <summary>
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechStreamingRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that is to be synthesised. e.g. 'Hello there [pause 1s] friend'
        /// </param>
        /// <param name="voiceId">
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </param>
        /// <param name="model">
        /// The model to use for audio output. Defaults to FALCON for all the regions except US-East. Valid values: FALCON, GEN2
        /// </param>
        /// <param name="channelType">
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </param>
        /// <param name="format">
        /// Format of the generated audio file.Valid values: MP3, FLAC, WAV, ALAW, ULAW, OGG, PCM<br/>
        /// Default Value: WAV
        /// </param>
        /// <param name="multiNativeLocale">
        /// This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.<br/>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="locale">
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
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
        /// Valid values are 8000, 16000, 24000, 44100, 48000. Defaults to 24000 for Falcon model and 44100 for Gen2 model.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="style">
        /// The voice style to be used for voiceover generation.
        /// </param>
        /// <param name="variation">
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateSpeechStreamingRequest(
            string text,
            string voiceId,
            string? model,
            string? channelType,
            string? format,
            string? multiNativeLocale,
            string? locale,
            int? pitch,
            global::System.Collections.Generic.Dictionary<string, global::G.PronunciationDetail>? pronunciationDictionary,
            int? rate,
            double? sampleRate,
            string? style,
            int? variation)
        {
            this.Model = model;
            this.ChannelType = channelType;
            this.Format = format;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechStreamingRequest" /> class.
        /// </summary>
        public GenerateSpeechStreamingRequest()
        {
        }
    }
}