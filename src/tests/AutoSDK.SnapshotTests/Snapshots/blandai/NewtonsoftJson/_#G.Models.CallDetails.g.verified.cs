//HintName: G.Models.CallDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Duration in minutes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_length")]
        public float? CallLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public string? To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_data")]
        public object? RequestData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inbound")]
        public bool? Inbound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_at")]
        public global::System.DateTime? EndAt { get; set; }

        /// <summary>
        /// Call progression status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_status")]
        public global::G.CallDetailsQueueStatus? QueueStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration")]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// System and dynamic variables generated during the call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Who answered the call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answered_by")]
        public global::G.CallDetailsAnsweredBy? AnsweredBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("record")]
        public bool? Record { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recording_url")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// AI-generated call summary
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Cost in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price")]
        public float? Price { get; set; }

        /// <summary>
        /// Who ended the call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_ended_by")]
        public global::G.CallDetailsCallEndedBy? CallEndedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pathway_logs")]
        public string? PathwayLogs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pathway_version")]
        public int? PathwayVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis_schema")]
        public object? AnalysisSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis")]
        public object? Analysis { get; set; }

        /// <summary>
        /// Full call text without system messages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concatenated_transcript")]
        public string? ConcatenatedTranscript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcripts")]
        public global::System.Collections.Generic.IList<global::G.TranscriptEntry>? Transcripts { get; set; }

        /// <summary>
        /// Final call status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.CallDetailsStatus? Status { get; set; }

        /// <summary>
        /// Actual call duration in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corrected_duration")]
        public string? CorrectedDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transferred_to")]
        public string? TransferredTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transferred_at")]
        public global::System.DateTime? TransferredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallDetails" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callLength">
        /// Duration in minutes
        /// </param>
        /// <param name="batchId"></param>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="requestData"></param>
        /// <param name="completed"></param>
        /// <param name="inbound"></param>
        /// <param name="createdAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="endAt"></param>
        /// <param name="queueStatus">
        /// Call progression status
        /// </param>
        /// <param name="maxDuration"></param>
        /// <param name="errorMessage"></param>
        /// <param name="variables">
        /// System and dynamic variables generated during the call
        /// </param>
        /// <param name="answeredBy">
        /// Who answered the call
        /// </param>
        /// <param name="record"></param>
        /// <param name="recordingUrl"></param>
        /// <param name="metadata"></param>
        /// <param name="summary">
        /// AI-generated call summary
        /// </param>
        /// <param name="price">
        /// Cost in USD
        /// </param>
        /// <param name="callEndedBy">
        /// Who ended the call
        /// </param>
        /// <param name="pathwayId"></param>
        /// <param name="pathwayLogs"></param>
        /// <param name="pathwayVersion"></param>
        /// <param name="analysisSchema"></param>
        /// <param name="analysis"></param>
        /// <param name="concatenatedTranscript">
        /// Full call text without system messages
        /// </param>
        /// <param name="transcripts"></param>
        /// <param name="status">
        /// Final call status
        /// </param>
        /// <param name="correctedDuration">
        /// Actual call duration in seconds
        /// </param>
        /// <param name="voiceId"></param>
        /// <param name="transferredTo"></param>
        /// <param name="transferredAt"></param>
        public CallDetails(
            string? callId,
            float? callLength,
            string? batchId,
            string? to,
            string? from,
            object? requestData,
            bool? completed,
            bool? inbound,
            global::System.DateTime? createdAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? endAt,
            global::G.CallDetailsQueueStatus? queueStatus,
            int? maxDuration,
            string? errorMessage,
            object? variables,
            global::G.CallDetailsAnsweredBy? answeredBy,
            bool? record,
            string? recordingUrl,
            object? metadata,
            string? summary,
            float? price,
            global::G.CallDetailsCallEndedBy? callEndedBy,
            string? pathwayId,
            string? pathwayLogs,
            int? pathwayVersion,
            object? analysisSchema,
            object? analysis,
            string? concatenatedTranscript,
            global::System.Collections.Generic.IList<global::G.TranscriptEntry>? transcripts,
            global::G.CallDetailsStatus? status,
            string? correctedDuration,
            string? voiceId,
            string? transferredTo,
            global::System.DateTime? transferredAt)
        {
            this.CallId = callId;
            this.CallLength = callLength;
            this.BatchId = batchId;
            this.To = to;
            this.From = from;
            this.RequestData = requestData;
            this.Completed = completed;
            this.Inbound = inbound;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.EndAt = endAt;
            this.QueueStatus = queueStatus;
            this.MaxDuration = maxDuration;
            this.ErrorMessage = errorMessage;
            this.Variables = variables;
            this.AnsweredBy = answeredBy;
            this.Record = record;
            this.RecordingUrl = recordingUrl;
            this.Metadata = metadata;
            this.Summary = summary;
            this.Price = price;
            this.CallEndedBy = callEndedBy;
            this.PathwayId = pathwayId;
            this.PathwayLogs = pathwayLogs;
            this.PathwayVersion = pathwayVersion;
            this.AnalysisSchema = analysisSchema;
            this.Analysis = analysis;
            this.ConcatenatedTranscript = concatenatedTranscript;
            this.Transcripts = transcripts;
            this.Status = status;
            this.CorrectedDuration = correctedDuration;
            this.VoiceId = voiceId;
            this.TransferredTo = transferredTo;
            this.TransferredAt = transferredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallDetails" /> class.
        /// </summary>
        public CallDetails()
        {
        }
    }
}