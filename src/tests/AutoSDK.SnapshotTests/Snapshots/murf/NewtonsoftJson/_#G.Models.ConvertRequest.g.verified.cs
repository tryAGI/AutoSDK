//HintName: G.Models.ConvertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertRequest
    {
        /// <summary>
        /// This parameter allows specifying the duration (in seconds) for the generated audio. If the value is 0, this parameter will be ignored. Only available for Gen2 model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_duration")]
        public double? AudioDuration { get; set; }

        /// <summary>
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_type")]
        public string? ChannelType { get; set; }

        /// <summary>
        /// Set to true to receive audio in response as a Base64 encoded string along with a url.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encode_output_as_base64")]
        public bool? EncodeOutputAsBase64 { get; set; }

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW<br/>
        /// Default Value: WAV
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc.<br/>
        /// Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multi_native_locale")]
        public string? MultiNativeLocale { get; set; }

        /// <summary>
        /// Pitch of the voiceover
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pitch")]
        public int? Pitch { get; set; }

        /// <summary>
        /// A JSON string that defines custom pronunciations for specific words or phrases. Each key is a word or phrase, and its value is an object with `type` and `pronunciation`.<br/>
        /// Example 1: '{"live": {"type": "IPA", "pronunciation": "laɪv"}}'<br/>
        /// Example 2: '{"2022": {"type": "SAY_AS", "pronunciation": "twenty twenty two"}}'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary")]
        public string? PronunciationDictionary { get; set; }

        /// <summary>
        /// Speed of the voiceover
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// Set to true to retain the original accent of the speaker during voice generation.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retain_accent")]
        public bool? RetainAccent { get; set; }

        /// <summary>
        /// Indicates whether to retain the original prosody (intonation, rhythm, and stress) of the input voice in the generated output.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retain_prosody")]
        public bool? RetainProsody { get; set; }

        /// <summary>
        /// Set to true to include a textual transcription of the generated audio in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_transcription")]
        public bool? ReturnTranscription { get; set; }

        /// <summary>
        /// Valid values are 8000, 24000, 44100, 48000<br/>
        /// Default Value: 44100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// The voice style to be used for voiceover generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public string? Style { get; set; }

        /// <summary>
        /// This parameter allows specifying a transcription of the audio clip, which will then be used as input for the voice changer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variation")]
        public int? Variation { get; set; }

        /// <summary>
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertRequest" /> class.
        /// </summary>
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
        /// <param name="encodeOutputAsBase64">
        /// Set to true to receive audio in response as a Base64 encoded string along with a url.
        /// </param>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="fileUrl"></param>
        /// <param name="format">
        /// Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW<br/>
        /// Default Value: WAV
        /// </param>
        /// <param name="multiNativeLocale">
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc.<br/>
        /// Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="pitch">
        /// Pitch of the voiceover
        /// </param>
        /// <param name="pronunciationDictionary">
        /// A JSON string that defines custom pronunciations for specific words or phrases. Each key is a word or phrase, and its value is an object with `type` and `pronunciation`.<br/>
        /// Example 1: '{"live": {"type": "IPA", "pronunciation": "laɪv"}}'<br/>
        /// Example 2: '{"2022": {"type": "SAY_AS", "pronunciation": "twenty twenty two"}}'
        /// </param>
        /// <param name="rate">
        /// Speed of the voiceover
        /// </param>
        /// <param name="retainAccent">
        /// Set to true to retain the original accent of the speaker during voice generation.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="retainProsody">
        /// Indicates whether to retain the original prosody (intonation, rhythm, and stress) of the input voice in the generated output.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="returnTranscription">
        /// Set to true to include a textual transcription of the generated audio in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sampleRate">
        /// Valid values are 8000, 24000, 44100, 48000<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="style">
        /// The voice style to be used for voiceover generation.
        /// </param>
        /// <param name="transcription">
        /// This parameter allows specifying a transcription of the audio clip, which will then be used as input for the voice changer
        /// </param>
        /// <param name="variation">
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </param>
        public ConvertRequest(
            string voiceId,
            double? audioDuration,
            string? channelType,
            bool? encodeOutputAsBase64,
            byte[]? file,
            string? filename,
            string? fileUrl,
            string? format,
            string? multiNativeLocale,
            int? pitch,
            string? pronunciationDictionary,
            int? rate,
            bool? retainAccent,
            bool? retainProsody,
            bool? returnTranscription,
            double? sampleRate,
            string? style,
            string? transcription,
            int? variation)
        {
            this.AudioDuration = audioDuration;
            this.ChannelType = channelType;
            this.EncodeOutputAsBase64 = encodeOutputAsBase64;
            this.File = file;
            this.Filename = filename;
            this.FileUrl = fileUrl;
            this.Format = format;
            this.MultiNativeLocale = multiNativeLocale;
            this.Pitch = pitch;
            this.PronunciationDictionary = pronunciationDictionary;
            this.Rate = rate;
            this.RetainAccent = retainAccent;
            this.RetainProsody = retainProsody;
            this.ReturnTranscription = returnTranscription;
            this.SampleRate = sampleRate;
            this.Style = style;
            this.Transcription = transcription;
            this.Variation = variation;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertRequest" /> class.
        /// </summary>
        public ConvertRequest()
        {
        }
    }
}