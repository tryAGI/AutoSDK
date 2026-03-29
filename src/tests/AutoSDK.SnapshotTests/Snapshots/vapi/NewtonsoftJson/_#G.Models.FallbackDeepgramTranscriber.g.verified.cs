//HintName: G.Models.FallbackDeepgramTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackDeepgramTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.FallbackDeepgramTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the Deepgram model that will be used. A list of models can be found here: https://developers.deepgram.com/docs/models-languages-overview
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.OneOf<global::G.FallbackDeepgramTranscriberModel?, string>? Model { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription. The list of languages Deepgram supports can be found here: https://developers.deepgram.com/docs/models-languages-overview
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.FallbackDeepgramTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// This will be use smart format option provided by Deepgram. It's default disabled because it can sometimes format numbers as times but it's getting better.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("smartFormat")]
        public bool? SmartFormat { get; set; }

        /// <summary>
        /// If set to true, this will add mip_opt_out=true as a query parameter of all API requests. See https://developers.deepgram.com/docs/the-deepgram-model-improvement-partnership-program#want-to-opt-out<br/>
        /// This will only be used if you are using your own Deepgram API key.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("mipOptOut")]
        public bool? MipOptOut { get; set; }

        /// <summary>
        /// If set to true, this will cause deepgram to convert spoken numbers to literal numerals. For example, "my phone number is nine-seven-two..." would become "my phone number is 972..."<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("numerals")]
        public bool? Numerals { get; set; }

        /// <summary>
        /// If set to true, Deepgram will replace profanity in transcripts with surrounding asterisks, e.g. "f***".<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("profanityFilter")]
        public bool? ProfanityFilter { get; set; }

        /// <summary>
        /// Transcripts below this confidence threshold will be discarded.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::Newtonsoft.Json.JsonProperty("confidenceThreshold")]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// Eager end-of-turn confidence required to fire a eager end-of-turn event. Setting a value here will enable EagerEndOfTurn and SpeechResumed events. It is disabled by default. Only used with Flux models.<br/>
        /// Example: 0.3F
        /// </summary>
        /// <example>0.3F</example>
        [global::Newtonsoft.Json.JsonProperty("eagerEotThreshold")]
        public double? EagerEotThreshold { get; set; }

        /// <summary>
        /// End-of-turn confidence required to finish a turn. Only used with Flux models.<br/>
        /// @default 0.7<br/>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
        [global::Newtonsoft.Json.JsonProperty("eotThreshold")]
        public double? EotThreshold { get; set; }

        /// <summary>
        /// A turn will be finished when this much time has passed after speech, regardless of EOT confidence. Only used with Flux models.<br/>
        /// @default 5000<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::Newtonsoft.Json.JsonProperty("eotTimeoutMs")]
        public double? EotTimeoutMs { get; set; }

        /// <summary>
        /// These keywords are passed to the transcription model to help it pick up use-case specific words. Anything that may not be a common word, like your company name, should be added here.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Keyterm Prompting allows you improve Keyword Recall Rate (KRR) for important keyterms or phrases up to 90%.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyterm")]
        public global::System.Collections.Generic.IList<string>? Keyterm { get; set; }

        /// <summary>
        /// This is the timeout after which Deepgram will send transcription on user silence. You can read in-depth documentation here: https://developers.deepgram.com/docs/endpointing.<br/>
        /// Here are the most important bits:<br/>
        /// - Defaults to 10. This is recommended for most use cases to optimize for latency.<br/>
        /// - 10 can cause some missing transcriptions since because of the shorter context. This mostly happens for one-word utterances. For those uses cases, it's recommended to try 300. It will add a bit of latency but the quality and reliability of the experience will be better.<br/>
        /// - If neither 10 nor 300 work, contact support@vapi.ai and we'll find another solution.<br/>
        /// @default 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpointing")]
        public double? Endpointing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackDeepgramTranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the Deepgram model that will be used. A list of models can be found here: https://developers.deepgram.com/docs/models-languages-overview
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription. The list of languages Deepgram supports can be found here: https://developers.deepgram.com/docs/models-languages-overview
        /// </param>
        /// <param name="smartFormat">
        /// This will be use smart format option provided by Deepgram. It's default disabled because it can sometimes format numbers as times but it's getting better.<br/>
        /// Example: false
        /// </param>
        /// <param name="mipOptOut">
        /// If set to true, this will add mip_opt_out=true as a query parameter of all API requests. See https://developers.deepgram.com/docs/the-deepgram-model-improvement-partnership-program#want-to-opt-out<br/>
        /// This will only be used if you are using your own Deepgram API key.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="numerals">
        /// If set to true, this will cause deepgram to convert spoken numbers to literal numerals. For example, "my phone number is nine-seven-two..." would become "my phone number is 972..."<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="profanityFilter">
        /// If set to true, Deepgram will replace profanity in transcripts with surrounding asterisks, e.g. "f***".<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="confidenceThreshold">
        /// Transcripts below this confidence threshold will be discarded.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="eagerEotThreshold">
        /// Eager end-of-turn confidence required to fire a eager end-of-turn event. Setting a value here will enable EagerEndOfTurn and SpeechResumed events. It is disabled by default. Only used with Flux models.<br/>
        /// Example: 0.3F
        /// </param>
        /// <param name="eotThreshold">
        /// End-of-turn confidence required to finish a turn. Only used with Flux models.<br/>
        /// @default 0.7<br/>
        /// Example: 0.7F
        /// </param>
        /// <param name="eotTimeoutMs">
        /// A turn will be finished when this much time has passed after speech, regardless of EOT confidence. Only used with Flux models.<br/>
        /// @default 5000<br/>
        /// Example: 5000
        /// </param>
        /// <param name="keywords">
        /// These keywords are passed to the transcription model to help it pick up use-case specific words. Anything that may not be a common word, like your company name, should be added here.
        /// </param>
        /// <param name="keyterm">
        /// Keyterm Prompting allows you improve Keyword Recall Rate (KRR) for important keyterms or phrases up to 90%.
        /// </param>
        /// <param name="endpointing">
        /// This is the timeout after which Deepgram will send transcription on user silence. You can read in-depth documentation here: https://developers.deepgram.com/docs/endpointing.<br/>
        /// Here are the most important bits:<br/>
        /// - Defaults to 10. This is recommended for most use cases to optimize for latency.<br/>
        /// - 10 can cause some missing transcriptions since because of the shorter context. This mostly happens for one-word utterances. For those uses cases, it's recommended to try 300. It will add a bit of latency but the quality and reliability of the experience will be better.<br/>
        /// - If neither 10 nor 300 work, contact support@vapi.ai and we'll find another solution.<br/>
        /// @default 10
        /// </param>
        public FallbackDeepgramTranscriber(
            global::G.FallbackDeepgramTranscriberProvider provider,
            global::G.OneOf<global::G.FallbackDeepgramTranscriberModel?, string>? model,
            global::G.FallbackDeepgramTranscriberLanguage? language,
            bool? smartFormat,
            bool? mipOptOut,
            bool? numerals,
            bool? profanityFilter,
            double? confidenceThreshold,
            double? eagerEotThreshold,
            double? eotThreshold,
            double? eotTimeoutMs,
            global::System.Collections.Generic.IList<string>? keywords,
            global::System.Collections.Generic.IList<string>? keyterm,
            double? endpointing)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.SmartFormat = smartFormat;
            this.MipOptOut = mipOptOut;
            this.Numerals = numerals;
            this.ProfanityFilter = profanityFilter;
            this.ConfidenceThreshold = confidenceThreshold;
            this.EagerEotThreshold = eagerEotThreshold;
            this.EotThreshold = eotThreshold;
            this.EotTimeoutMs = eotTimeoutMs;
            this.Keywords = keywords;
            this.Keyterm = keyterm;
            this.Endpointing = endpointing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackDeepgramTranscriber" /> class.
        /// </summary>
        public FallbackDeepgramTranscriber()
        {
        }
    }
}