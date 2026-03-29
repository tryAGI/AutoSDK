//HintName: G.Models.SpeechmaticsTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechmaticsTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechmaticsTranscriberProviderJsonConverter))]
        public global::G.SpeechmaticsTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the model that will be used for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechmaticsTranscriberModelJsonConverter))]
        public global::G.SpeechmaticsTranscriberModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechmaticsTranscriberLanguageJsonConverter))]
        public global::G.SpeechmaticsTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// This is the operating point for the transcription. Choose between `standard` for faster turnaround with strong accuracy or `enhanced` for highest accuracy when precision is critical.<br/>
        /// @default 'enhanced'<br/>
        /// Default Value: enhanced<br/>
        /// Example: enhanced
        /// </summary>
        /// <example>enhanced</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operatingPoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechmaticsTranscriberOperatingPointJsonConverter))]
        public global::G.SpeechmaticsTranscriberOperatingPoint? OperatingPoint { get; set; }

        /// <summary>
        /// This is the region for the Speechmatics API. Choose between EU (Europe) and US (United States) regions for lower latency and data sovereignty compliance.<br/>
        /// @default 'eu'<br/>
        /// Default Value: eu<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechmaticsTranscriberRegionJsonConverter))]
        public global::G.SpeechmaticsTranscriberRegion? Region { get; set; }

        /// <summary>
        /// This enables speaker diarization, which identifies and separates speakers in the transcription. Essential for multi-speaker conversations and conference calls.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableDiarization")]
        public bool? EnableDiarization { get; set; }

        /// <summary>
        /// This sets the maximum delay in milliseconds for partial transcripts. Balances latency and accuracy.<br/>
        /// @default 3000<br/>
        /// Default Value: 3000<br/>
        /// Example: 1500
        /// </summary>
        /// <example>1500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDelay")]
        public double? MaxDelay { get; set; }

        /// <summary>
        /// Example: [{"content":"Speechmatics","soundsLike":["speech mattix"]}]
        /// </summary>
        /// <example>[{"content":"Speechmatics","soundsLike":["speech mattix"]}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customVocabulary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SpeechmaticsCustomVocabularyItem> CustomVocabulary { get; set; }

        /// <summary>
        /// This controls how numbers, dates, currencies, and other entities are formatted in the transcription output.<br/>
        /// @default 'written'<br/>
        /// Default Value: written<br/>
        /// Example: spoken
        /// </summary>
        /// <example>spoken</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeralStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechmaticsTranscriberNumeralStyleJsonConverter))]
        public global::G.SpeechmaticsTranscriberNumeralStyle? NumeralStyle { get; set; }

        /// <summary>
        /// This is the sensitivity level for end-of-turn detection, which determines when a speaker has finished talking. Higher values are more sensitive.<br/>
        /// @default 0.5<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endOfTurnSensitivity")]
        public double? EndOfTurnSensitivity { get; set; }

        /// <summary>
        /// This enables removal of disfluencies (um, uh) from the transcript to create cleaner, more professional output.<br/>
        /// This is only supported for the English language transcriber.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeDisfluencies")]
        public bool? RemoveDisfluencies { get; set; }

        /// <summary>
        /// This is the minimum duration in seconds for speech segments. Shorter segments will be filtered out. Helps remove noise and improve accuracy.<br/>
        /// @default 0.0<br/>
        /// Default Value: 0<br/>
        /// Example: 0.2F
        /// </summary>
        /// <example>0.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumSpeechDuration")]
        public double? MinimumSpeechDuration { get; set; }

        /// <summary>
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackPlan")]
        public global::G.FallbackTranscriberPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechmaticsTranscriber" /> class.
        /// </summary>
        /// <param name="customVocabulary">
        /// Example: [{"content":"Speechmatics","soundsLike":["speech mattix"]}]
        /// </param>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the model that will be used for the transcription.
        /// </param>
        /// <param name="language"></param>
        /// <param name="operatingPoint">
        /// This is the operating point for the transcription. Choose between `standard` for faster turnaround with strong accuracy or `enhanced` for highest accuracy when precision is critical.<br/>
        /// @default 'enhanced'<br/>
        /// Default Value: enhanced<br/>
        /// Example: enhanced
        /// </param>
        /// <param name="region">
        /// This is the region for the Speechmatics API. Choose between EU (Europe) and US (United States) regions for lower latency and data sovereignty compliance.<br/>
        /// @default 'eu'<br/>
        /// Default Value: eu<br/>
        /// Example: us
        /// </param>
        /// <param name="enableDiarization">
        /// This enables speaker diarization, which identifies and separates speakers in the transcription. Essential for multi-speaker conversations and conference calls.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="maxDelay">
        /// This sets the maximum delay in milliseconds for partial transcripts. Balances latency and accuracy.<br/>
        /// @default 3000<br/>
        /// Default Value: 3000<br/>
        /// Example: 1500
        /// </param>
        /// <param name="numeralStyle">
        /// This controls how numbers, dates, currencies, and other entities are formatted in the transcription output.<br/>
        /// @default 'written'<br/>
        /// Default Value: written<br/>
        /// Example: spoken
        /// </param>
        /// <param name="endOfTurnSensitivity">
        /// This is the sensitivity level for end-of-turn detection, which determines when a speaker has finished talking. Higher values are more sensitive.<br/>
        /// @default 0.5<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.8F
        /// </param>
        /// <param name="removeDisfluencies">
        /// This enables removal of disfluencies (um, uh) from the transcript to create cleaner, more professional output.<br/>
        /// This is only supported for the English language transcriber.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="minimumSpeechDuration">
        /// This is the minimum duration in seconds for speech segments. Shorter segments will be filtered out. Helps remove noise and improve accuracy.<br/>
        /// @default 0.0<br/>
        /// Default Value: 0<br/>
        /// Example: 0.2F
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechmaticsTranscriber(
            global::System.Collections.Generic.IList<global::G.SpeechmaticsCustomVocabularyItem> customVocabulary,
            global::G.SpeechmaticsTranscriberProvider provider,
            global::G.SpeechmaticsTranscriberModel? model,
            global::G.SpeechmaticsTranscriberLanguage? language,
            global::G.SpeechmaticsTranscriberOperatingPoint? operatingPoint,
            global::G.SpeechmaticsTranscriberRegion? region,
            bool? enableDiarization,
            double? maxDelay,
            global::G.SpeechmaticsTranscriberNumeralStyle? numeralStyle,
            double? endOfTurnSensitivity,
            bool? removeDisfluencies,
            double? minimumSpeechDuration,
            global::G.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.OperatingPoint = operatingPoint;
            this.Region = region;
            this.EnableDiarization = enableDiarization;
            this.MaxDelay = maxDelay;
            this.CustomVocabulary = customVocabulary ?? throw new global::System.ArgumentNullException(nameof(customVocabulary));
            this.NumeralStyle = numeralStyle;
            this.EndOfTurnSensitivity = endOfTurnSensitivity;
            this.RemoveDisfluencies = removeDisfluencies;
            this.MinimumSpeechDuration = minimumSpeechDuration;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechmaticsTranscriber" /> class.
        /// </summary>
        public SpeechmaticsTranscriber()
        {
        }
    }
}