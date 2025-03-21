﻿//HintName: G.Models.Batch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `batch`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.BatchObject Object { get; set; }

        /// <summary>
        /// The OpenAI API endpoint used by the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::G.BatchErrors? Errors { get; set; }

        /// <summary>
        /// The ID of the input file for the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputFileId { get; set; } = default!;

        /// <summary>
        /// The time frame within which the batch should be processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_window", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompletionWindow { get; set; } = default!;

        /// <summary>
        /// The current status of the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchStatus Status { get; set; } = default!;

        /// <summary>
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// The ID of the file containing the outputs of requests with errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_progress_at")]
        public global::System.DateTimeOffset? InProgressAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finalizing_at")]
        public global::System.DateTimeOffset? FinalizingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at")]
        public global::System.DateTimeOffset? FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired_at")]
        public global::System.DateTimeOffset? ExpiredAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelling_at")]
        public global::System.DateTimeOffset? CancellingAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_at")]
        public global::System.DateTimeOffset? CancelledAt { get; set; }

        /// <summary>
        /// The request counts for different statuses within the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_counts")]
        public global::G.BatchRequestCounts? RequestCounts { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// The object type, which is always `batch`.
        /// </param>
        /// <param name="endpoint">
        /// The OpenAI API endpoint used by the batch.
        /// </param>
        /// <param name="errors"></param>
        /// <param name="inputFileId">
        /// The ID of the input file for the batch.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed.
        /// </param>
        /// <param name="status">
        /// The current status of the batch.
        /// </param>
        /// <param name="outputFileId">
        /// The ID of the file containing the outputs of successfully executed requests.
        /// </param>
        /// <param name="errorFileId">
        /// The ID of the file containing the outputs of requests with errors.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the batch was created.
        /// </param>
        /// <param name="inProgressAt">
        /// The Unix timestamp (in seconds) for when the batch started processing.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the batch will expire.
        /// </param>
        /// <param name="finalizingAt">
        /// The Unix timestamp (in seconds) for when the batch started finalizing.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp (in seconds) for when the batch was completed.
        /// </param>
        /// <param name="failedAt">
        /// The Unix timestamp (in seconds) for when the batch failed.
        /// </param>
        /// <param name="expiredAt">
        /// The Unix timestamp (in seconds) for when the batch expired.
        /// </param>
        /// <param name="cancellingAt">
        /// The Unix timestamp (in seconds) for when the batch started cancelling.
        /// </param>
        /// <param name="cancelledAt">
        /// The Unix timestamp (in seconds) for when the batch was cancelled.
        /// </param>
        /// <param name="requestCounts">
        /// The request counts for different statuses within the batch.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        public Batch(
            string id,
            string endpoint,
            string inputFileId,
            string completionWindow,
            global::G.BatchStatus status,
            global::System.DateTimeOffset createdAt,
            global::G.BatchObject @object,
            global::G.BatchErrors? errors,
            string? outputFileId,
            string? errorFileId,
            global::System.DateTimeOffset? inProgressAt,
            global::System.DateTimeOffset? expiresAt,
            global::System.DateTimeOffset? finalizingAt,
            global::System.DateTimeOffset? completedAt,
            global::System.DateTimeOffset? failedAt,
            global::System.DateTimeOffset? expiredAt,
            global::System.DateTimeOffset? cancellingAt,
            global::System.DateTimeOffset? cancelledAt,
            global::G.BatchRequestCounts? requestCounts,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Object = @object;
            this.Errors = errors;
            this.OutputFileId = outputFileId;
            this.ErrorFileId = errorFileId;
            this.InProgressAt = inProgressAt;
            this.ExpiresAt = expiresAt;
            this.FinalizingAt = finalizingAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.ExpiredAt = expiredAt;
            this.CancellingAt = cancellingAt;
            this.CancelledAt = cancelledAt;
            this.RequestCounts = requestCounts;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }
    }
}