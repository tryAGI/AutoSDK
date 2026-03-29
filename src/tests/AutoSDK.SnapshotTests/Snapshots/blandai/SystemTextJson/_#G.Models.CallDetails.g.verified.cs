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
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Duration in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_length")]
        public float? CallLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_data")]
        public object? RequestData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound")]
        public bool? Inbound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_at")]
        public global::System.DateTime? EndAt { get; set; }

        /// <summary>
        /// Call progression status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallDetailsQueueStatusJsonConverter))]
        public global::G.CallDetailsQueueStatus? QueueStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration")]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// System and dynamic variables generated during the call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Who answered the call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answered_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallDetailsAnsweredByJsonConverter))]
        public global::G.CallDetailsAnsweredBy? AnsweredBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record")]
        public bool? Record { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_url")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// AI-generated call summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Cost in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public float? Price { get; set; }

        /// <summary>
        /// Who ended the call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ended_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallDetailsCallEndedByJsonConverter))]
        public global::G.CallDetailsCallEndedBy? CallEndedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathway_logs")]
        public string? PathwayLogs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathway_version")]
        public int? PathwayVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_schema")]
        public object? AnalysisSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        public object? Analysis { get; set; }

        /// <summary>
        /// Full call text without system messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concatenated_transcript")]
        public string? ConcatenatedTranscript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcripts")]
        public global::System.Collections.Generic.IList<global::G.TranscriptEntry>? Transcripts { get; set; }

        /// <summary>
        /// Final call status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallDetailsStatusJsonConverter))]
        public global::G.CallDetailsStatus? Status { get; set; }

        /// <summary>
        /// Actual call duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrected_duration")]
        public string? CorrectedDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferred_to")]
        public string? TransferredTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferred_at")]
        public global::System.DateTime? TransferredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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