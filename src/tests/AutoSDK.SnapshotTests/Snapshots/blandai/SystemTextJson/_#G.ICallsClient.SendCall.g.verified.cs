//HintName: G.ICallsClient.SendCall.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Send Call<br/>
        /// Send an AI phone call with a custom objective and actions. Requires either a `task` (prompt) or `pathway_id`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SendCallResponse> SendCallAsync(

            global::G.SendCallRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Call<br/>
        /// Send an AI phone call with a custom objective and actions. Requires either a `task` (prompt) or `pathway_id`.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SendCallResponse> SendCallAsync(
            string phoneNumber,
            string? task = default,
            string? pathwayId = default,
            int? pathwayVersion = default,
            string? voice = default,
            string? firstSentence = default,
            string? personaId = default,
            global::G.SendCallRequestModel? model = default,
            string? language = default,
            float? temperature = default,
            bool? waitForGreeting = default,
            int? interruptionThreshold = default,
            string? from = default,
            string? timezone = default,
            string? startTime = default,
            int? maxDuration = default,
            string? transferPhoneNumber = default,
            global::System.Collections.Generic.Dictionary<string, string>? transferList = default,
            global::System.Collections.Generic.IList<string>? tools = default,
            object? requestData = default,
            global::G.SendCallRequestBackgroundTrack? backgroundTrack = default,
            bool? noiseCancellation = default,
            bool? blockInterruptions = default,
            bool? record = default,
            global::G.VoicemailConfig? voicemail = default,
            global::System.Collections.Generic.IList<global::G.SendCallRequestPronunciationGuideItem>? pronunciationGuide = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            string? webhook = default,
            global::System.Collections.Generic.IList<global::G.SendCallRequestWebhookEvent>? webhookEvents = default,
            object? metadata = default,
            string? summaryPrompt = default,
            global::System.Collections.Generic.IList<string>? dispositions = default,
            global::System.Collections.Generic.IList<object>? dynamicData = default,
            bool? ignoreButtonPress = default,
            string? precallDtmfSequence = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}