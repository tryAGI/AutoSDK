//HintName: G.Models.BetaMessageBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageBatch
    {
        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Message Batches, this is always `"message_batch"`.<br/>
        /// Default Value: message_batch
        /// </summary>
        /// <default>global::G.BetaMessageBatchType.MessageBatch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaMessageBatchTypeJsonConverter))]
        public global::G.BetaMessageBatchType Type { get; set; } = global::G.BetaMessageBatchType.MessageBatch;

        /// <summary>
        /// Processing status of the Message Batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaMessageBatchProcessingStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BetaMessageBatchProcessingStatus ProcessingStatus { get; set; }

        /// <summary>
        /// Tallies requests within the Message Batch, categorized by their status.<br/>
        /// Requests start as `processing` and move to one of the other statuses only once processing of the entire batch ends. The sum of all values always matches the total number of requests in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BetaRequestCounts RequestCounts { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time at which processing for the Message Batch ended. Specified only once processing ends.<br/>
        /// Processing ends when every request in a Message Batch has either succeeded, errored, canceled, or expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch will expire and end processing, which is 24 hours after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch was archived and its results became unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time at which cancellation was initiated for the Message Batch. Specified only if cancellation was initiated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_initiated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CancelInitiatedAt { get; set; }

        /// <summary>
        /// URL to a `.jsonl` file containing the results of the Message Batch requests. Specified only once processing ends.<br/>
        /// Results in the file are not guaranteed to be in the same order as requests. Use the `custom_id` field to match results to requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ResultsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatch" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Message Batches, this is always `"message_batch"`.<br/>
        /// Default Value: message_batch
        /// </param>
        /// <param name="processingStatus">
        /// Processing status of the Message Batch.
        /// </param>
        /// <param name="requestCounts">
        /// Tallies requests within the Message Batch, categorized by their status.<br/>
        /// Requests start as `processing` and move to one of the other statuses only once processing of the entire batch ends. The sum of all values always matches the total number of requests in the batch.
        /// </param>
        /// <param name="endedAt">
        /// RFC 3339 datetime string representing the time at which processing for the Message Batch ended. Specified only once processing ends.<br/>
        /// Processing ends when every request in a Message Batch has either succeeded, errored, canceled, or expired.
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 datetime string representing the time at which the Message Batch was created.
        /// </param>
        /// <param name="expiresAt">
        /// RFC 3339 datetime string representing the time at which the Message Batch will expire and end processing, which is 24 hours after creation.
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 datetime string representing the time at which the Message Batch was archived and its results became unavailable.
        /// </param>
        /// <param name="cancelInitiatedAt">
        /// RFC 3339 datetime string representing the time at which cancellation was initiated for the Message Batch. Specified only if cancellation was initiated.
        /// </param>
        /// <param name="resultsUrl">
        /// URL to a `.jsonl` file containing the results of the Message Batch requests. Specified only once processing ends.<br/>
        /// Results in the file are not guaranteed to be in the same order as requests. Use the `custom_id` field to match results to requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessageBatch(
            string id,
            global::G.BetaMessageBatchProcessingStatus processingStatus,
            global::G.BetaRequestCounts requestCounts,
            global::System.DateTime? endedAt,
            global::System.DateTime createdAt,
            global::System.DateTime expiresAt,
            global::System.DateTime? archivedAt,
            global::System.DateTime? cancelInitiatedAt,
            string? resultsUrl,
            global::G.BetaMessageBatchType type = global::G.BetaMessageBatchType.MessageBatch)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessingStatus = processingStatus;
            this.RequestCounts = requestCounts ?? throw new global::System.ArgumentNullException(nameof(requestCounts));
            this.EndedAt = endedAt ?? throw new global::System.ArgumentNullException(nameof(endedAt));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.ArchivedAt = archivedAt ?? throw new global::System.ArgumentNullException(nameof(archivedAt));
            this.CancelInitiatedAt = cancelInitiatedAt ?? throw new global::System.ArgumentNullException(nameof(cancelInitiatedAt));
            this.ResultsUrl = resultsUrl ?? throw new global::System.ArgumentNullException(nameof(resultsUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatch" /> class.
        /// </summary>
        public BetaMessageBatch()
        {
        }
    }
}