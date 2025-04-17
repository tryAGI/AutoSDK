//HintName: G.Models.BatchJobOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file")]
        public global::System.Guid? ErrorFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BatchError> Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> InputFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Default Value: batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchJobOutObjectJsonConverter))]
        public global::G.BatchJobOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file")]
        public global::System.Guid? OutputFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SucceededRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobOut" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="completedRequests"></param>
        /// <param name="createdAt"></param>
        /// <param name="endpoint"></param>
        /// <param name="errorFile"></param>
        /// <param name="errors"></param>
        /// <param name="failedRequests"></param>
        /// <param name="id"></param>
        /// <param name="inputFiles"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="object">
        /// Default Value: batch
        /// </param>
        /// <param name="outputFile"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="succeededRequests"></param>
        /// <param name="totalRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobOut(
            int completedRequests,
            int createdAt,
            string endpoint,
            global::System.Collections.Generic.IList<global::G.BatchError> errors,
            int failedRequests,
            string id,
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            string model,
            global::G.BatchJobStatus status,
            int succeededRequests,
            int totalRequests,
            int? completedAt,
            global::System.Guid? errorFile,
            object? metadata,
            global::G.BatchJobOutObject? @object,
            global::System.Guid? outputFile,
            int? startedAt)
        {
            this.CompletedRequests = completedRequests;
            this.CreatedAt = createdAt;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.FailedRequests = failedRequests;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputFiles = inputFiles ?? throw new global::System.ArgumentNullException(nameof(inputFiles));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status;
            this.SucceededRequests = succeededRequests;
            this.TotalRequests = totalRequests;
            this.CompletedAt = completedAt;
            this.ErrorFile = errorFile;
            this.Metadata = metadata;
            this.Object = @object;
            this.OutputFile = outputFile;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobOut" /> class.
        /// </summary>
        public BatchJobOut()
        {
        }
    }
}