//HintName: G.Models.V2CallBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2CallBase
    {
        /// <summary>
        /// Unique id of the call. Used to identify the call in the LLM websocket and used to authenticate in the audio websocket.<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Corresponding agent id of this call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Name of the agent.<br/>
        /// Example: My Agent
        /// </summary>
        /// <example>My Agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// The version of the agent.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentVersion { get; set; }

        /// <summary>
        /// Status of call.<br/>
        /// - `registered`: Call id issued, starting to make a call using this id.<br/>
        /// - `ongoing`: Call connected and ongoing.<br/>
        /// - `ended`: The underlying websocket has ended for the call. Either user or agent hung up, or call transferred.<br/>
        /// - `error`: Call encountered error.<br/>
        /// Example: registered
        /// </summary>
        /// <example>registered</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.V2CallBaseCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.V2CallBaseCallStatus CallStatus { get; set; }

        /// <summary>
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </summary>
        /// <example>{"customer_name":"John Doe"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retell_llm_dynamic_variables")]
        public object? RetellLlmDynamicVariables { get; set; }

        /// <summary>
        /// Dynamic variables collected from the call. Only available after the call ends.<br/>
        /// Example: {"last_node_name":"Test node"}
        /// </summary>
        /// <example>{"last_node_name":"Test node"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("collected_dynamic_variables")]
        public object? CollectedDynamicVariables { get; set; }

        /// <summary>
        /// Custom SIP headers to be added to the call.<br/>
        /// Example: {"X-Custom-Header":"Custom Value"}
        /// </summary>
        /// <example>{"X-Custom-Header":"Custom Value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomSipHeaders { get; set; }

        /// <summary>
        /// Data storage setting for this call's agent. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata.<br/>
        /// Example: everything
        /// </summary>
        /// <example>everything</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_storage_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.V2CallBaseDataStorageSettingJsonConverter))]
        public global::G.V2CallBaseDataStorageSetting? DataStorageSetting { get; set; }

        /// <summary>
        /// Whether this agent opts in for signed URLs for public logs and recordings. When enabled, the generated URLs will include security signatures that restrict access and automatically expire after 24 hours.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opt_in_signed_url")]
        public bool? OptInSignedUrl { get; set; }

        /// <summary>
        /// Begin timestamp (milliseconds since epoch) of the call. Available after call starts.<br/>
        /// Example: 1703302407333
        /// </summary>
        /// <example>1703302407333</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// End timestamp (milliseconds since epoch) of the call. Available after call ends.<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// Transfer end timestamp (milliseconds since epoch) of the call. Available after transfer call ends.<br/>
        /// Example: 1703302628855
        /// </summary>
        /// <example>1703302628855</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_end_timestamp")]
        public long? TransferEndTimestamp { get; set; }

        /// <summary>
        /// Duration of the call in milliseconds. Available after call ends.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Transcription of the call. Available after call ends.<br/>
        /// Example: Agent: hi how are you doing?<br/>
        /// User: Doing pretty well. How are you?<br/>
        /// Agent: That's great to hear! I'm doing well too, thanks! What's up?<br/>
        /// User: I don't have anything in particular.<br/>
        /// Agent: Got it, just checking in!<br/>
        /// User: Alright. See you.<br/>
        /// Agent: have a nice day
        /// </summary>
        /// <example>
        /// Agent: hi how are you doing?<br/>
        /// User: Doing pretty well. How are you?<br/>
        /// Agent: That's great to hear! I'm doing well too, thanks! What's up?<br/>
        /// User: I don't have anything in particular.<br/>
        /// Agent: Got it, just checking in!<br/>
        /// User: Alright. See you.<br/>
        /// Agent: have a nice day
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Transcript of the call in the format of a list of utterance, with timestamp. Available after call ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_object")]
        public global::System.Collections.Generic.IList<global::G.Utterance>? TranscriptObject { get; set; }

        /// <summary>
        /// Transcript of the call weaved with tool call invocation and results. It precisely captures when (at what utterance, which word) the tool was invoked and what was the result. Available after call ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_with_tool_calls")]
        public global::System.Collections.Generic.IList<global::G.UtteranceOrToolCall>? TranscriptWithToolCalls { get; set; }

        /// <summary>
        /// Transcript of the call weaved with tool call invocation and results, without PII. It precisely captures when (at what utterance, which word) the tool was invoked and what was the result. Available after call ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrubbed_transcript_with_tool_calls")]
        public global::System.Collections.Generic.IList<global::G.UtteranceOrToolCall>? ScrubbedTranscriptWithToolCalls { get; set; }

        /// <summary>
        /// Recording of the call. Available after call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording.wav
        /// </summary>
        /// <example>https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_url")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// Recording of the call, with each party's audio stored in a separate channel. Available after the call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording_multichannel.wav
        /// </summary>
        /// <example>https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording_multichannel.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_multi_channel_url")]
        public string? RecordingMultiChannelUrl { get; set; }

        /// <summary>
        /// Recording of the call without PII. Available after call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording.wav
        /// </summary>
        /// <example>https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrubbed_recording_url")]
        public string? ScrubbedRecordingUrl { get; set; }

        /// <summary>
        /// Recording of the call without PII, with each party's audio stored in a separate channel. Available after the call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording_multichannel.wav
        /// </summary>
        /// <example>https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording_multichannel.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrubbed_recording_multi_channel_url")]
        public string? ScrubbedRecordingMultiChannelUrl { get; set; }

        /// <summary>
        /// Public log of the call, containing details about all the requests and responses received in LLM WebSocket, latency tracking for each turntaking, helpful for debugging and tracing. Available after call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/public_log.txt
        /// </summary>
        /// <example>https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/public_log.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_log_url")]
        public string? PublicLogUrl { get; set; }

        /// <summary>
        /// URL to the knowledge base retrieved contents of the call. Available after call ends if the call utilizes knowledge base feature. It consists of the respond id and the retrieved contents related to that response. It's already rendered in call history tab of dashboard, and you can also manually download and check against the transcript to view the knowledge base retrieval results.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/kb_retrieved_contents.txt
        /// </summary>
        /// <example>https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/kb_retrieved_contents.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_retrieved_contents_url")]
        public string? KnowledgeBaseRetrievedContentsUrl { get; set; }

        /// <summary>
        /// Latency tracking of the call, available after call ends. Not all fields here will be available, as it depends on the type of call and feature used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public global::G.V2CallBaseLatency? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DisconnectionReason4JsonConverter))]
        public global::G.DisconnectionReason4? DisconnectionReason { get; set; }

        /// <summary>
        /// The destination number or identifier where the call was transferred to. Only populated when the disconnection reason was `call_transfer`. Can be a phone number or a SIP URI. SIP URIs are prefixed with "sip:" and may include a ";transport=..." portion (if transport is known) where the transport type can be "tls", "tcp" or "udp".<br/>
        /// Example: +12137771234
        /// </summary>
        /// <example>+12137771234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        public string? TransferDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_analysis")]
        public global::G.CallAnalysis? CallAnalysis { get; set; }

        /// <summary>
        /// Cost of the call, including all the products and their costs and discount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_cost")]
        public global::G.V2CallBaseCallCost? CallCost { get; set; }

        /// <summary>
        /// LLM token usage of the call, available after call ends. Not populated if using custom LLM, realtime API, or no LLM call is made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_token_usage")]
        public global::G.V2CallBaseLlmTokenUsage? LlmTokenUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBase" /> class.
        /// </summary>
        /// <param name="callId">
        /// Unique id of the call. Used to identify the call in the LLM websocket and used to authenticate in the audio websocket.<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="agentId">
        /// Corresponding agent id of this call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="agentVersion">
        /// The version of the agent.<br/>
        /// Example: 1
        /// </param>
        /// <param name="callStatus">
        /// Status of call.<br/>
        /// - `registered`: Call id issued, starting to make a call using this id.<br/>
        /// - `ongoing`: Call connected and ongoing.<br/>
        /// - `ended`: The underlying websocket has ended for the call. Either user or agent hung up, or call transferred.<br/>
        /// - `error`: Call encountered error.<br/>
        /// Example: registered
        /// </param>
        /// <param name="agentName">
        /// Name of the agent.<br/>
        /// Example: My Agent
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        /// <param name="collectedDynamicVariables">
        /// Dynamic variables collected from the call. Only available after the call ends.<br/>
        /// Example: {"last_node_name":"Test node"}
        /// </param>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to be added to the call.<br/>
        /// Example: {"X-Custom-Header":"Custom Value"}
        /// </param>
        /// <param name="dataStorageSetting">
        /// Data storage setting for this call's agent. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata.<br/>
        /// Example: everything
        /// </param>
        /// <param name="optInSignedUrl">
        /// Whether this agent opts in for signed URLs for public logs and recordings. When enabled, the generated URLs will include security signatures that restrict access and automatically expire after 24 hours.<br/>
        /// Example: true
        /// </param>
        /// <param name="startTimestamp">
        /// Begin timestamp (milliseconds since epoch) of the call. Available after call starts.<br/>
        /// Example: 1703302407333
        /// </param>
        /// <param name="endTimestamp">
        /// End timestamp (milliseconds since epoch) of the call. Available after call ends.<br/>
        /// Example: 1703302428855
        /// </param>
        /// <param name="transferEndTimestamp">
        /// Transfer end timestamp (milliseconds since epoch) of the call. Available after transfer call ends.<br/>
        /// Example: 1703302628855
        /// </param>
        /// <param name="durationMs">
        /// Duration of the call in milliseconds. Available after call ends.<br/>
        /// Example: 10000
        /// </param>
        /// <param name="transcript">
        /// Transcription of the call. Available after call ends.<br/>
        /// Example: Agent: hi how are you doing?<br/>
        /// User: Doing pretty well. How are you?<br/>
        /// Agent: That's great to hear! I'm doing well too, thanks! What's up?<br/>
        /// User: I don't have anything in particular.<br/>
        /// Agent: Got it, just checking in!<br/>
        /// User: Alright. See you.<br/>
        /// Agent: have a nice day
        /// </param>
        /// <param name="transcriptObject">
        /// Transcript of the call in the format of a list of utterance, with timestamp. Available after call ends.
        /// </param>
        /// <param name="transcriptWithToolCalls">
        /// Transcript of the call weaved with tool call invocation and results. It precisely captures when (at what utterance, which word) the tool was invoked and what was the result. Available after call ends.
        /// </param>
        /// <param name="scrubbedTranscriptWithToolCalls">
        /// Transcript of the call weaved with tool call invocation and results, without PII. It precisely captures when (at what utterance, which word) the tool was invoked and what was the result. Available after call ends.
        /// </param>
        /// <param name="recordingUrl">
        /// Recording of the call. Available after call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording.wav
        /// </param>
        /// <param name="recordingMultiChannelUrl">
        /// Recording of the call, with each party's audio stored in a separate channel. Available after the call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording_multichannel.wav
        /// </param>
        /// <param name="scrubbedRecordingUrl">
        /// Recording of the call without PII. Available after call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording.wav
        /// </param>
        /// <param name="scrubbedRecordingMultiChannelUrl">
        /// Recording of the call without PII, with each party's audio stored in a separate channel. Available after the call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/recording_multichannel.wav
        /// </param>
        /// <param name="publicLogUrl">
        /// Public log of the call, containing details about all the requests and responses received in LLM WebSocket, latency tracking for each turntaking, helpful for debugging and tracing. Available after call ends.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/public_log.txt
        /// </param>
        /// <param name="knowledgeBaseRetrievedContentsUrl">
        /// URL to the knowledge base retrieved contents of the call. Available after call ends if the call utilizes knowledge base feature. It consists of the respond id and the retrieved contents related to that response. It's already rendered in call history tab of dashboard, and you can also manually download and check against the transcript to view the knowledge base retrieval results.<br/>
        /// Example: https://retellai.s3.us-west-2.amazonaws.com/Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6/kb_retrieved_contents.txt
        /// </param>
        /// <param name="latency">
        /// Latency tracking of the call, available after call ends. Not all fields here will be available, as it depends on the type of call and feature used.
        /// </param>
        /// <param name="disconnectionReason"></param>
        /// <param name="transferDestination">
        /// The destination number or identifier where the call was transferred to. Only populated when the disconnection reason was `call_transfer`. Can be a phone number or a SIP URI. SIP URIs are prefixed with "sip:" and may include a ";transport=..." portion (if transport is known) where the transport type can be "tls", "tcp" or "udp".<br/>
        /// Example: +12137771234
        /// </param>
        /// <param name="callAnalysis"></param>
        /// <param name="callCost">
        /// Cost of the call, including all the products and their costs and discount.
        /// </param>
        /// <param name="llmTokenUsage">
        /// LLM token usage of the call, available after call ends. Not populated if using custom LLM, realtime API, or no LLM call is made.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2CallBase(
            string callId,
            string agentId,
            int agentVersion,
            global::G.V2CallBaseCallStatus callStatus,
            string? agentName,
            object? metadata,
            object? retellLlmDynamicVariables,
            object? collectedDynamicVariables,
            global::System.Collections.Generic.Dictionary<string, string>? customSipHeaders,
            global::G.V2CallBaseDataStorageSetting? dataStorageSetting,
            bool? optInSignedUrl,
            long? startTimestamp,
            long? endTimestamp,
            long? transferEndTimestamp,
            int? durationMs,
            string? transcript,
            global::System.Collections.Generic.IList<global::G.Utterance>? transcriptObject,
            global::System.Collections.Generic.IList<global::G.UtteranceOrToolCall>? transcriptWithToolCalls,
            global::System.Collections.Generic.IList<global::G.UtteranceOrToolCall>? scrubbedTranscriptWithToolCalls,
            string? recordingUrl,
            string? recordingMultiChannelUrl,
            string? scrubbedRecordingUrl,
            string? scrubbedRecordingMultiChannelUrl,
            string? publicLogUrl,
            string? knowledgeBaseRetrievedContentsUrl,
            global::G.V2CallBaseLatency? latency,
            global::G.DisconnectionReason4? disconnectionReason,
            string? transferDestination,
            global::G.CallAnalysis? callAnalysis,
            global::G.V2CallBaseCallCost? callCost,
            global::G.V2CallBaseLlmTokenUsage? llmTokenUsage)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName;
            this.AgentVersion = agentVersion;
            this.CallStatus = callStatus;
            this.Metadata = metadata;
            this.RetellLlmDynamicVariables = retellLlmDynamicVariables;
            this.CollectedDynamicVariables = collectedDynamicVariables;
            this.CustomSipHeaders = customSipHeaders;
            this.DataStorageSetting = dataStorageSetting;
            this.OptInSignedUrl = optInSignedUrl;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.TransferEndTimestamp = transferEndTimestamp;
            this.DurationMs = durationMs;
            this.Transcript = transcript;
            this.TranscriptObject = transcriptObject;
            this.TranscriptWithToolCalls = transcriptWithToolCalls;
            this.ScrubbedTranscriptWithToolCalls = scrubbedTranscriptWithToolCalls;
            this.RecordingUrl = recordingUrl;
            this.RecordingMultiChannelUrl = recordingMultiChannelUrl;
            this.ScrubbedRecordingUrl = scrubbedRecordingUrl;
            this.ScrubbedRecordingMultiChannelUrl = scrubbedRecordingMultiChannelUrl;
            this.PublicLogUrl = publicLogUrl;
            this.KnowledgeBaseRetrievedContentsUrl = knowledgeBaseRetrievedContentsUrl;
            this.Latency = latency;
            this.DisconnectionReason = disconnectionReason;
            this.TransferDestination = transferDestination;
            this.CallAnalysis = callAnalysis;
            this.CallCost = callCost;
            this.LlmTokenUsage = llmTokenUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CallBase" /> class.
        /// </summary>
        public V2CallBase()
        {
        }
    }
}