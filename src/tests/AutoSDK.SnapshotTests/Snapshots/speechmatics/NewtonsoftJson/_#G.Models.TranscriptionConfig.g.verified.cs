//HintName: G.Models.TranscriptionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
    /// </summary>
    public sealed partial class TranscriptionConfig
    {
        /// <summary>
        /// Language model to process the audio input, normally specified as an ISO language code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Request a specialized model based on 'language' but optimized for a particular field, e.g. "finance" or "medical".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Language locale to be used when generating the transcription output, normally specified as an ISO language code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_locale")]
        public string? OutputLocale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operating_point")]
        public global::G.OperatingPoint? OperatingPoint { get; set; }

        /// <summary>
        /// List of custom words or phrases that should be recognized. Alternative pronunciations can be specified to aid recognition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_vocab")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionConfigAdditionalVocabItem>? AdditionalVocab { get; set; }

        /// <summary>
        /// Control punctuation settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("punctuation_overrides")]
        public global::G.TranscriptionConfigPunctuationOverrides? PunctuationOverrides { get; set; }

        /// <summary>
        /// Specify whether speaker or channel labels are added to the transcript.<br/>
        /// The default is `none`.<br/>
        ///   - **none**: no speaker or channel labels are added.<br/>
        ///   - **speaker**: speaker attribution is performed based on acoustic matching;<br/>
        ///              all input channels are mixed into a single stream for processing.<br/>
        ///   - **channel**: multiple input channels are processed individually and collated<br/>
        ///             into a single transcript.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diarization")]
        public global::G.TranscriptionConfigDiarization? Diarization { get; set; }

        /// <summary>
        /// Transcript labels to use when using collating separate input channels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_diarization_labels")]
        public global::System.Collections.Generic.IList<string>? ChannelDiarizationLabels { get; set; }

        /// <summary>
        /// Include additional 'entity' objects in the transcription results (e.g. dates, numbers) and their original spoken form. These entities are interleaved with other types of results. The concatenation of these words is represented as a single entity with the concatenated written form present in the 'content' field. The entities contain a 'spoken_form' field, which can be used in place of the corresponding 'word' type results, in case a spoken form is preferred to a written form. They also contain a 'written_form', which can be used instead of the entity, if you want a breakdown of the words without spaces. They can still contain non-breaking spaces and other special whitespace characters, as they are considered part of the word for the formatting output. In case of a written_form, the individual word times are estimated and might not be accurate if the order of the words in the written form does not correspond to the order they were actually spoken (such as 'one hundred million dollars' and '$100 million').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_entities")]
        public bool? EnableEntities { get; set; }

        /// <summary>
        /// Whether or not to enable flexible endpointing and allow the entity to continue to be spoken.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_delay_mode")]
        public global::G.TranscriptionConfigMaxDelayMode? MaxDelayMode { get; set; }

        /// <summary>
        /// Configuration for limiting the transcription of quiet audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_filtering_config")]
        public global::G.TranscriptionConfigAudioFilteringConfig? AudioFilteringConfig { get; set; }

        /// <summary>
        /// Configuration for applying filtering to the transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_filtering_config")]
        public global::G.TranscriptionConfigTranscriptFilteringConfig? TranscriptFilteringConfig { get; set; }

        /// <summary>
        /// Configuration for speaker diarization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_diarization_config")]
        public global::G.TranscriptionConfigSpeakerDiarizationConfig? SpeakerDiarizationConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        /// <param name="language">
        /// Language model to process the audio input, normally specified as an ISO language code
        /// </param>
        /// <param name="domain">
        /// Request a specialized model based on 'language' but optimized for a particular field, e.g. "finance" or "medical".
        /// </param>
        /// <param name="outputLocale">
        /// Language locale to be used when generating the transcription output, normally specified as an ISO language code
        /// </param>
        /// <param name="operatingPoint"></param>
        /// <param name="additionalVocab">
        /// List of custom words or phrases that should be recognized. Alternative pronunciations can be specified to aid recognition.
        /// </param>
        /// <param name="punctuationOverrides">
        /// Control punctuation settings.
        /// </param>
        /// <param name="diarization">
        /// Specify whether speaker or channel labels are added to the transcript.<br/>
        /// The default is `none`.<br/>
        ///   - **none**: no speaker or channel labels are added.<br/>
        ///   - **speaker**: speaker attribution is performed based on acoustic matching;<br/>
        ///              all input channels are mixed into a single stream for processing.<br/>
        ///   - **channel**: multiple input channels are processed individually and collated<br/>
        ///             into a single transcript.
        /// </param>
        /// <param name="channelDiarizationLabels">
        /// Transcript labels to use when using collating separate input channels.
        /// </param>
        /// <param name="enableEntities">
        /// Include additional 'entity' objects in the transcription results (e.g. dates, numbers) and their original spoken form. These entities are interleaved with other types of results. The concatenation of these words is represented as a single entity with the concatenated written form present in the 'content' field. The entities contain a 'spoken_form' field, which can be used in place of the corresponding 'word' type results, in case a spoken form is preferred to a written form. They also contain a 'written_form', which can be used instead of the entity, if you want a breakdown of the words without spaces. They can still contain non-breaking spaces and other special whitespace characters, as they are considered part of the word for the formatting output. In case of a written_form, the individual word times are estimated and might not be accurate if the order of the words in the written form does not correspond to the order they were actually spoken (such as 'one hundred million dollars' and '$100 million').
        /// </param>
        /// <param name="maxDelayMode">
        /// Whether or not to enable flexible endpointing and allow the entity to continue to be spoken.
        /// </param>
        /// <param name="audioFilteringConfig">
        /// Configuration for limiting the transcription of quiet audio.
        /// </param>
        /// <param name="transcriptFilteringConfig">
        /// Configuration for applying filtering to the transcription.
        /// </param>
        /// <param name="speakerDiarizationConfig">
        /// Configuration for speaker diarization
        /// </param>
        public TranscriptionConfig(
            string language,
            string? domain,
            string? outputLocale,
            global::G.OperatingPoint? operatingPoint,
            global::System.Collections.Generic.IList<global::G.TranscriptionConfigAdditionalVocabItem>? additionalVocab,
            global::G.TranscriptionConfigPunctuationOverrides? punctuationOverrides,
            global::G.TranscriptionConfigDiarization? diarization,
            global::System.Collections.Generic.IList<string>? channelDiarizationLabels,
            bool? enableEntities,
            global::G.TranscriptionConfigMaxDelayMode? maxDelayMode,
            global::G.TranscriptionConfigAudioFilteringConfig? audioFilteringConfig,
            global::G.TranscriptionConfigTranscriptFilteringConfig? transcriptFilteringConfig,
            global::G.TranscriptionConfigSpeakerDiarizationConfig? speakerDiarizationConfig)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Domain = domain;
            this.OutputLocale = outputLocale;
            this.OperatingPoint = operatingPoint;
            this.AdditionalVocab = additionalVocab;
            this.PunctuationOverrides = punctuationOverrides;
            this.Diarization = diarization;
            this.ChannelDiarizationLabels = channelDiarizationLabels;
            this.EnableEntities = enableEntities;
            this.MaxDelayMode = maxDelayMode;
            this.AudioFilteringConfig = audioFilteringConfig;
            this.TranscriptFilteringConfig = transcriptFilteringConfig;
            this.SpeakerDiarizationConfig = speakerDiarizationConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        public TranscriptionConfig()
        {
        }
    }
}