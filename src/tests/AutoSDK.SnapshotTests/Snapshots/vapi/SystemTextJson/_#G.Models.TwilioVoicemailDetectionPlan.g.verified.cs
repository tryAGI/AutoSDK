//HintName: G.Models.TwilioVoicemailDetectionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TwilioVoicemailDetectionPlan
    {
        /// <summary>
        /// This is the provider to use for voicemail detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TwilioVoicemailDetectionPlanProviderJsonConverter))]
        public global::G.TwilioVoicemailDetectionPlanProvider Provider { get; set; }

        /// <summary>
        /// These are the AMD messages from Twilio that are considered as voicemail. Default is ['machine_end_beep', 'machine_end_silence'].<br/>
        /// @default {Array} ['machine_end_beep', 'machine_end_silence']<br/>
        /// Example: [machine_end_beep, machine_end_silence]
        /// </summary>
        /// <example>[machine_end_beep, machine_end_silence]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemailDetectionTypes")]
        public global::System.Collections.Generic.IList<global::G.TwilioVoicemailDetectionPlanVoicemailDetectionType>? VoicemailDetectionTypes { get; set; }

        /// <summary>
        /// This sets whether the assistant should detect voicemail. Defaults to true.<br/>
        /// @default true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The number of seconds that Twilio should attempt to perform answering machine detection before timing out and returning AnsweredBy as unknown. Default is 30 seconds.<br/>
        /// Increasing this value will provide the engine more time to make a determination. This can be useful when DetectMessageEnd is provided in the MachineDetection parameter and there is an expectation of long answering machine greetings that can exceed 30 seconds.<br/>
        /// Decreasing this value will reduce the amount of time the engine has to make a determination. This can be particularly useful when the Enable option is provided in the MachineDetection parameter and you want to limit the time for initial detection.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineDetectionTimeout")]
        public double? MachineDetectionTimeout { get; set; }

        /// <summary>
        /// The number of milliseconds that is used as the measuring stick for the length of the speech activity. Durations lower than this value will be interpreted as a human, longer as a machine. Default is 2400 milliseconds.<br/>
        /// Increasing this value will reduce the chance of a False Machine (detected machine, actually human) for a long human greeting (e.g., a business greeting) but increase the time it takes to detect a machine.<br/>
        /// Decreasing this value will reduce the chances of a False Human (detected human, actually machine) for short voicemail greetings. The value of this parameter may need to be reduced by more than 1000ms to detect very short voicemail greetings. A reduction of that significance can result in increased False Machine detections. Adjusting the MachineDetectionSpeechEndThreshold is likely the better approach for short voicemails. Decreasing MachineDetectionSpeechThreshold will also reduce the time it takes to detect a machine.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 2400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineDetectionSpeechThreshold")]
        public double? MachineDetectionSpeechThreshold { get; set; }

        /// <summary>
        /// The number of milliseconds of silence after speech activity at which point the speech activity is considered complete. Default is 1200 milliseconds.<br/>
        /// Increasing this value will typically be used to better address the short voicemail greeting scenarios. For short voicemails, there is typically 1000-2000ms of audio followed by 1200-2400ms of silence and then additional audio before the beep. Increasing the MachineDetectionSpeechEndThreshold to ~2500ms will treat the 1200-2400ms of silence as a gap in the greeting but not the end of the greeting and will result in a machine detection. The downsides of such a change include:<br/>
        /// - Increasing the delay for human detection by the amount you increase this parameter, e.g., a change of 1200ms to 2500ms increases human detection delay by 1300ms.<br/>
        /// - Cases where a human has two utterances separated by a period of silence (e.g. a "Hello", then 2000ms of silence, and another "Hello") may be interpreted as a machine.<br/>
        /// Decreasing this value will result in faster human detection. The consequence is that it can lead to increased False Human (detected human, actually machine) detections because a silence gap in a voicemail greeting (not necessarily just in short voicemail scenarios) can be incorrectly interpreted as the end of speech.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 1200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineDetectionSpeechEndThreshold")]
        public double? MachineDetectionSpeechEndThreshold { get; set; }

        /// <summary>
        /// The number of milliseconds of initial silence after which an unknown AnsweredBy result will be returned. Default is 5000 milliseconds.<br/>
        /// Increasing this value will result in waiting for a longer period of initial silence before returning an 'unknown' AMD result.<br/>
        /// Decreasing this value will result in waiting for a shorter period of initial silence before returning an 'unknown' AMD result.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineDetectionSilenceTimeout")]
        public double? MachineDetectionSilenceTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioVoicemailDetectionPlan" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider to use for voicemail detection.
        /// </param>
        /// <param name="voicemailDetectionTypes">
        /// These are the AMD messages from Twilio that are considered as voicemail. Default is ['machine_end_beep', 'machine_end_silence'].<br/>
        /// @default {Array} ['machine_end_beep', 'machine_end_silence']<br/>
        /// Example: [machine_end_beep, machine_end_silence]
        /// </param>
        /// <param name="enabled">
        /// This sets whether the assistant should detect voicemail. Defaults to true.<br/>
        /// @default true
        /// </param>
        /// <param name="machineDetectionTimeout">
        /// The number of seconds that Twilio should attempt to perform answering machine detection before timing out and returning AnsweredBy as unknown. Default is 30 seconds.<br/>
        /// Increasing this value will provide the engine more time to make a determination. This can be useful when DetectMessageEnd is provided in the MachineDetection parameter and there is an expectation of long answering machine greetings that can exceed 30 seconds.<br/>
        /// Decreasing this value will reduce the amount of time the engine has to make a determination. This can be particularly useful when the Enable option is provided in the MachineDetection parameter and you want to limit the time for initial detection.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 30
        /// </param>
        /// <param name="machineDetectionSpeechThreshold">
        /// The number of milliseconds that is used as the measuring stick for the length of the speech activity. Durations lower than this value will be interpreted as a human, longer as a machine. Default is 2400 milliseconds.<br/>
        /// Increasing this value will reduce the chance of a False Machine (detected machine, actually human) for a long human greeting (e.g., a business greeting) but increase the time it takes to detect a machine.<br/>
        /// Decreasing this value will reduce the chances of a False Human (detected human, actually machine) for short voicemail greetings. The value of this parameter may need to be reduced by more than 1000ms to detect very short voicemail greetings. A reduction of that significance can result in increased False Machine detections. Adjusting the MachineDetectionSpeechEndThreshold is likely the better approach for short voicemails. Decreasing MachineDetectionSpeechThreshold will also reduce the time it takes to detect a machine.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 2400
        /// </param>
        /// <param name="machineDetectionSpeechEndThreshold">
        /// The number of milliseconds of silence after speech activity at which point the speech activity is considered complete. Default is 1200 milliseconds.<br/>
        /// Increasing this value will typically be used to better address the short voicemail greeting scenarios. For short voicemails, there is typically 1000-2000ms of audio followed by 1200-2400ms of silence and then additional audio before the beep. Increasing the MachineDetectionSpeechEndThreshold to ~2500ms will treat the 1200-2400ms of silence as a gap in the greeting but not the end of the greeting and will result in a machine detection. The downsides of such a change include:<br/>
        /// - Increasing the delay for human detection by the amount you increase this parameter, e.g., a change of 1200ms to 2500ms increases human detection delay by 1300ms.<br/>
        /// - Cases where a human has two utterances separated by a period of silence (e.g. a "Hello", then 2000ms of silence, and another "Hello") may be interpreted as a machine.<br/>
        /// Decreasing this value will result in faster human detection. The consequence is that it can lead to increased False Human (detected human, actually machine) detections because a silence gap in a voicemail greeting (not necessarily just in short voicemail scenarios) can be incorrectly interpreted as the end of speech.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 1200
        /// </param>
        /// <param name="machineDetectionSilenceTimeout">
        /// The number of milliseconds of initial silence after which an unknown AnsweredBy result will be returned. Default is 5000 milliseconds.<br/>
        /// Increasing this value will result in waiting for a longer period of initial silence before returning an 'unknown' AMD result.<br/>
        /// Decreasing this value will result in waiting for a shorter period of initial silence before returning an 'unknown' AMD result.<br/>
        /// Check the [Twilio docs](https://www.twilio.com/docs/voice/answering-machine-detection#optional-api-tuning-parameters) for more info.<br/>
        /// @default 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioVoicemailDetectionPlan(
            global::G.TwilioVoicemailDetectionPlanProvider provider,
            global::System.Collections.Generic.IList<global::G.TwilioVoicemailDetectionPlanVoicemailDetectionType>? voicemailDetectionTypes,
            bool? enabled,
            double? machineDetectionTimeout,
            double? machineDetectionSpeechThreshold,
            double? machineDetectionSpeechEndThreshold,
            double? machineDetectionSilenceTimeout)
        {
            this.Provider = provider;
            this.VoicemailDetectionTypes = voicemailDetectionTypes;
            this.Enabled = enabled;
            this.MachineDetectionTimeout = machineDetectionTimeout;
            this.MachineDetectionSpeechThreshold = machineDetectionSpeechThreshold;
            this.MachineDetectionSpeechEndThreshold = machineDetectionSpeechEndThreshold;
            this.MachineDetectionSilenceTimeout = machineDetectionSilenceTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioVoicemailDetectionPlan" /> class.
        /// </summary>
        public TwilioVoicemailDetectionPlan()
        {
        }
    }
}