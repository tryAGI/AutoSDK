//HintName: G.Models.SendCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendCallRequest
    {
        /// <summary>
        /// Phone number to call in E.164 format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Natural language instructions for the AI agent. Required if pathway_id is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task")]
        public string? Task { get; set; }

        /// <summary>
        /// ID of a conversational pathway to follow. Required if task is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// Pathway version number to use (default is production version)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pathway_version")]
        public int? PathwayVersion { get; set; }

        /// <summary>
        /// Voice ID or preset name (e.g. Josh, Florian, Derek, June, Nat, Paige)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Specific opening phrase for the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_sentence")]
        public string? FirstSentence { get; set; }

        /// <summary>
        /// ID of a pre-configured persona template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persona_id")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// Model type for the call<br/>
        /// Default Value: base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.SendCallRequestModel? Model { get; set; }

        /// <summary>
        /// Language code for transcription and speech optimization<br/>
        /// Default Value: babel-en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// LLM randomness (0-1)<br/>
        /// Default Value: 0.7
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Agent waits for callee to speak first<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wait_for_greeting")]
        public bool? WaitForGreeting { get; set; }

        /// <summary>
        /// Patience level in ms before responding (lower = quicker response)<br/>
        /// Default Value: 500
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interruption_threshold")]
        public int? InterruptionThreshold { get; set; }

        /// <summary>
        /// Caller ID number (must own the number)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// Timezone for the call (IANA format)<br/>
        /// Default Value: America/Los_Angeles
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Scheduled time in format YYYY-MM-DD HH:MM:SS -HH:MM
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Maximum call duration in minutes<br/>
        /// Default Value: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration")]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// Phone number for transferring to a human
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_phone_number")]
        public string? TransferPhoneNumber { get; set; }

        /// <summary>
        /// Multiple transfer routing options keyed by department name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_list")]
        public global::System.Collections.Generic.Dictionary<string, string>? TransferList { get; set; }

        /// <summary>
        /// Array of custom tool and knowledge base IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// Custom variables available in prompts and pathways
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_data")]
        public object? RequestData { get; set; }

        /// <summary>
        /// Background audio track
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_track")]
        public global::G.SendCallRequestBackgroundTrack? BackgroundTrack { get; set; }

        /// <summary>
        /// Filter background noise<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("noise_cancellation")]
        public bool? NoiseCancellation { get; set; }

        /// <summary>
        /// Prevent agent from processing user interruptions<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_interruptions")]
        public bool? BlockInterruptions { get; set; }

        /// <summary>
        /// Record the call (access via recording_url)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("record")]
        public bool? Record { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voicemail")]
        public global::G.VoicemailConfig? Voicemail { get; set; }

        /// <summary>
        /// Guide pronunciation of specific words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_guide")]
        public global::System.Collections.Generic.IList<global::G.SendCallRequestPronunciationGuideItem>? PronunciationGuide { get; set; }

        /// <summary>
        /// Words boosted in transcription (optional "word:boost" format)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// HTTPS URL for post-call data delivery
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Event types to stream to webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_events")]
        public global::System.Collections.Generic.IList<global::G.SendCallRequestWebhookEvent>? WebhookEvents { get; set; }

        /// <summary>
        /// Custom tracking data accessible regardless of call status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Custom instructions for call summary generation (max 2000 chars)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_prompt")]
        public string? SummaryPrompt { get; set; }

        /// <summary>
        /// Outcome tags for call classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dispositions")]
        public global::System.Collections.Generic.IList<string>? Dispositions { get; set; }

        /// <summary>
        /// External API data integration configurations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_data")]
        public global::System.Collections.Generic.IList<object>? DynamicData { get; set; }

        /// <summary>
        /// Disable DTMF keypad input
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_button_press")]
        public bool? IgnoreButtonPress { get; set; }

        /// <summary>
        /// DTMF digits played before call starts (0-9, *,
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("precall_dtmf_sequence")]
        public string? PrecallDtmfSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number to call in E.164 format
        /// </param>
        /// <param name="task">
        /// Natural language instructions for the AI agent. Required if pathway_id is not provided.
        /// </param>
        /// <param name="pathwayId">
        /// ID of a conversational pathway to follow. Required if task is not provided.
        /// </param>
        /// <param name="pathwayVersion">
        /// Pathway version number to use (default is production version)
        /// </param>
        /// <param name="voice">
        /// Voice ID or preset name (e.g. Josh, Florian, Derek, June, Nat, Paige)
        /// </param>
        /// <param name="firstSentence">
        /// Specific opening phrase for the agent
        /// </param>
        /// <param name="personaId">
        /// ID of a pre-configured persona template
        /// </param>
        /// <param name="model">
        /// Model type for the call<br/>
        /// Default Value: base
        /// </param>
        /// <param name="language">
        /// Language code for transcription and speech optimization<br/>
        /// Default Value: babel-en
        /// </param>
        /// <param name="temperature">
        /// LLM randomness (0-1)<br/>
        /// Default Value: 0.7
        /// </param>
        /// <param name="waitForGreeting">
        /// Agent waits for callee to speak first<br/>
        /// Default Value: false
        /// </param>
        /// <param name="interruptionThreshold">
        /// Patience level in ms before responding (lower = quicker response)<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="from">
        /// Caller ID number (must own the number)
        /// </param>
        /// <param name="timezone">
        /// Timezone for the call (IANA format)<br/>
        /// Default Value: America/Los_Angeles
        /// </param>
        /// <param name="startTime">
        /// Scheduled time in format YYYY-MM-DD HH:MM:SS -HH:MM
        /// </param>
        /// <param name="maxDuration">
        /// Maximum call duration in minutes<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="transferPhoneNumber">
        /// Phone number for transferring to a human
        /// </param>
        /// <param name="transferList">
        /// Multiple transfer routing options keyed by department name
        /// </param>
        /// <param name="tools">
        /// Array of custom tool and knowledge base IDs
        /// </param>
        /// <param name="requestData">
        /// Custom variables available in prompts and pathways
        /// </param>
        /// <param name="backgroundTrack">
        /// Background audio track
        /// </param>
        /// <param name="noiseCancellation">
        /// Filter background noise<br/>
        /// Default Value: false
        /// </param>
        /// <param name="blockInterruptions">
        /// Prevent agent from processing user interruptions<br/>
        /// Default Value: false
        /// </param>
        /// <param name="record">
        /// Record the call (access via recording_url)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="voicemail"></param>
        /// <param name="pronunciationGuide">
        /// Guide pronunciation of specific words
        /// </param>
        /// <param name="keywords">
        /// Words boosted in transcription (optional "word:boost" format)
        /// </param>
        /// <param name="webhook">
        /// HTTPS URL for post-call data delivery
        /// </param>
        /// <param name="webhookEvents">
        /// Event types to stream to webhook
        /// </param>
        /// <param name="metadata">
        /// Custom tracking data accessible regardless of call status
        /// </param>
        /// <param name="summaryPrompt">
        /// Custom instructions for call summary generation (max 2000 chars)
        /// </param>
        /// <param name="dispositions">
        /// Outcome tags for call classification
        /// </param>
        /// <param name="dynamicData">
        /// External API data integration configurations
        /// </param>
        /// <param name="ignoreButtonPress">
        /// Disable DTMF keypad input
        /// </param>
        /// <param name="precallDtmfSequence">
        /// DTMF digits played before call starts (0-9, *,
        /// </param>
        public SendCallRequest(
            string phoneNumber,
            string? task,
            string? pathwayId,
            int? pathwayVersion,
            string? voice,
            string? firstSentence,
            string? personaId,
            global::G.SendCallRequestModel? model,
            string? language,
            float? temperature,
            bool? waitForGreeting,
            int? interruptionThreshold,
            string? from,
            string? timezone,
            string? startTime,
            int? maxDuration,
            string? transferPhoneNumber,
            global::System.Collections.Generic.Dictionary<string, string>? transferList,
            global::System.Collections.Generic.IList<string>? tools,
            object? requestData,
            global::G.SendCallRequestBackgroundTrack? backgroundTrack,
            bool? noiseCancellation,
            bool? blockInterruptions,
            bool? record,
            global::G.VoicemailConfig? voicemail,
            global::System.Collections.Generic.IList<global::G.SendCallRequestPronunciationGuideItem>? pronunciationGuide,
            global::System.Collections.Generic.IList<string>? keywords,
            string? webhook,
            global::System.Collections.Generic.IList<global::G.SendCallRequestWebhookEvent>? webhookEvents,
            object? metadata,
            string? summaryPrompt,
            global::System.Collections.Generic.IList<string>? dispositions,
            global::System.Collections.Generic.IList<object>? dynamicData,
            bool? ignoreButtonPress,
            string? precallDtmfSequence)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Task = task;
            this.PathwayId = pathwayId;
            this.PathwayVersion = pathwayVersion;
            this.Voice = voice;
            this.FirstSentence = firstSentence;
            this.PersonaId = personaId;
            this.Model = model;
            this.Language = language;
            this.Temperature = temperature;
            this.WaitForGreeting = waitForGreeting;
            this.InterruptionThreshold = interruptionThreshold;
            this.From = from;
            this.Timezone = timezone;
            this.StartTime = startTime;
            this.MaxDuration = maxDuration;
            this.TransferPhoneNumber = transferPhoneNumber;
            this.TransferList = transferList;
            this.Tools = tools;
            this.RequestData = requestData;
            this.BackgroundTrack = backgroundTrack;
            this.NoiseCancellation = noiseCancellation;
            this.BlockInterruptions = blockInterruptions;
            this.Record = record;
            this.Voicemail = voicemail;
            this.PronunciationGuide = pronunciationGuide;
            this.Keywords = keywords;
            this.Webhook = webhook;
            this.WebhookEvents = webhookEvents;
            this.Metadata = metadata;
            this.SummaryPrompt = summaryPrompt;
            this.Dispositions = dispositions;
            this.DynamicData = dynamicData;
            this.IgnoreButtonPress = ignoreButtonPress;
            this.PrecallDtmfSequence = precallDtmfSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallRequest" /> class.
        /// </summary>
        public SendCallRequest()
        {
        }
    }
}