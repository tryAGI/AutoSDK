//HintName: G.Models.RunSchemaWithAnnotationQueueInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Run schema with annotation queue info.
    /// </summary>
    public sealed partial class RunSchemaWithAnnotationQueueInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_preview")]
        public string? InputsPreview { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunTypeEnum RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_order")]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialized")]
        public object? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_preview")]
        public string? OutputsPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        public global::System.Guid? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_id")]
        public global::System.Guid? ManifestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_s3_id")]
        public global::System.Guid? ManifestS3Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_s3_urls")]
        public object? InputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_s3_urls")]
        public object? OutputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_urls")]
        public object? S3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotted_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DottedOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direct_child_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? DirectChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ParentRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        public global::System.Collections.Generic.Dictionary<string, object>? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_example_id")]
        public global::System.Guid? ReferenceExampleId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_model_id")]
        public global::System.Guid? PriceModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_time")]
        public global::System.DateTime? FirstTokenTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_queued_at")]
        public global::System.DateTime? LastQueuedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_dataset")]
        public bool? InDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        public global::System.Guid? ShareToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TraceTierJsonConverter))]
        public global::G.TraceTier? TraceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_first_received_at")]
        public global::System.DateTime? TraceFirstReceivedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_upgrade")]
        public bool? TraceUpgrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid QueueRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reviewed_time")]
        public global::System.DateTime? LastReviewedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_added_at")]
        public global::System.DateTime? EffectiveAddedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSchemaWithAnnotationQueueInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="inputsPreview"></param>
        /// <param name="runType">
        /// Enum for run types.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="executionOrder">
        /// Default Value: 1
        /// </param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="outputsPreview"></param>
        /// <param name="parentRunId"></param>
        /// <param name="manifestId"></param>
        /// <param name="manifestS3Id"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="inputsS3Urls"></param>
        /// <param name="outputsS3Urls"></param>
        /// <param name="s3Urls"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="childRunIds"></param>
        /// <param name="directChildRunIds"></param>
        /// <param name="parentRunIds"></param>
        /// <param name="feedbackStats"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCost"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="priceModelId"></param>
        /// <param name="firstTokenTime"></param>
        /// <param name="sessionId"></param>
        /// <param name="appPath"></param>
        /// <param name="lastQueuedAt"></param>
        /// <param name="inDataset"></param>
        /// <param name="shareToken"></param>
        /// <param name="traceTier"></param>
        /// <param name="traceFirstReceivedAt"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="traceUpgrade">
        /// Default Value: false
        /// </param>
        /// <param name="queueRunId"></param>
        /// <param name="lastReviewedTime"></param>
        /// <param name="addedAt"></param>
        /// <param name="effectiveAddedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunSchemaWithAnnotationQueueInfo(
            string name,
            global::G.RunTypeEnum runType,
            global::System.Guid traceId,
            string dottedOrder,
            global::System.Guid id,
            string status,
            global::System.Guid sessionId,
            string appPath,
            global::System.Guid queueRunId,
            object? inputs,
            string? inputsPreview,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            object? extra,
            string? error,
            int? executionOrder,
            object? serialized,
            object? outputs,
            string? outputsPreview,
            global::System.Guid? parentRunId,
            global::System.Guid? manifestId,
            global::System.Guid? manifestS3Id,
            global::System.Collections.Generic.IList<object>? events,
            global::System.Collections.Generic.IList<string>? tags,
            object? inputsS3Urls,
            object? outputsS3Urls,
            object? s3Urls,
            global::System.Collections.Generic.IList<global::System.Guid>? childRunIds,
            global::System.Collections.Generic.IList<global::System.Guid>? directChildRunIds,
            global::System.Collections.Generic.IList<global::System.Guid>? parentRunIds,
            global::System.Collections.Generic.Dictionary<string, object>? feedbackStats,
            global::System.Guid? referenceExampleId,
            int? totalTokens,
            int? promptTokens,
            int? completionTokens,
            string? totalCost,
            string? promptCost,
            string? completionCost,
            global::System.Guid? priceModelId,
            global::System.DateTime? firstTokenTime,
            global::System.DateTime? lastQueuedAt,
            bool? inDataset,
            global::System.Guid? shareToken,
            global::G.TraceTier? traceTier,
            global::System.DateTime? traceFirstReceivedAt,
            int? ttlSeconds,
            bool? traceUpgrade,
            global::System.DateTime? lastReviewedTime,
            global::System.DateTime? addedAt,
            global::System.DateTime? effectiveAddedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RunType = runType;
            this.TraceId = traceId;
            this.DottedOrder = dottedOrder ?? throw new global::System.ArgumentNullException(nameof(dottedOrder));
            this.Id = id;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.SessionId = sessionId;
            this.AppPath = appPath ?? throw new global::System.ArgumentNullException(nameof(appPath));
            this.QueueRunId = queueRunId;
            this.Inputs = inputs;
            this.InputsPreview = inputsPreview;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Extra = extra;
            this.Error = error;
            this.ExecutionOrder = executionOrder;
            this.Serialized = serialized;
            this.Outputs = outputs;
            this.OutputsPreview = outputsPreview;
            this.ParentRunId = parentRunId;
            this.ManifestId = manifestId;
            this.ManifestS3Id = manifestS3Id;
            this.Events = events;
            this.Tags = tags;
            this.InputsS3Urls = inputsS3Urls;
            this.OutputsS3Urls = outputsS3Urls;
            this.S3Urls = s3Urls;
            this.ChildRunIds = childRunIds;
            this.DirectChildRunIds = directChildRunIds;
            this.ParentRunIds = parentRunIds;
            this.FeedbackStats = feedbackStats;
            this.ReferenceExampleId = referenceExampleId;
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalCost = totalCost;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.PriceModelId = priceModelId;
            this.FirstTokenTime = firstTokenTime;
            this.LastQueuedAt = lastQueuedAt;
            this.InDataset = inDataset;
            this.ShareToken = shareToken;
            this.TraceTier = traceTier;
            this.TraceFirstReceivedAt = traceFirstReceivedAt;
            this.TtlSeconds = ttlSeconds;
            this.TraceUpgrade = traceUpgrade;
            this.LastReviewedTime = lastReviewedTime;
            this.AddedAt = addedAt;
            this.EffectiveAddedAt = effectiveAddedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSchemaWithAnnotationQueueInfo" /> class.
        /// </summary>
        public RunSchemaWithAnnotationQueueInfo()
        {
        }
    }
}