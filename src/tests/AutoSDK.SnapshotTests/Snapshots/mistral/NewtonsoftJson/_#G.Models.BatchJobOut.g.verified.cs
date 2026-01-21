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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: batch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.BatchJobOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> InputFiles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_file")]
        public global::System.Guid? OutputFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_file")]
        public global::System.Guid? ErrorFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BatchError> Errors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletedRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("succeeded_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int SucceededRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: batch
        /// </param>
        /// <param name="inputFiles"></param>
        /// <param name="metadata"></param>
        /// <param name="endpoint"></param>
        /// <param name="model"></param>
        /// <param name="outputFile"></param>
        /// <param name="errorFile"></param>
        /// <param name="errors"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="totalRequests"></param>
        /// <param name="completedRequests"></param>
        /// <param name="succeededRequests"></param>
        /// <param name="failedRequests"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        public BatchJobOut(
            string id,
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            string endpoint,
            string model,
            global::System.Collections.Generic.IList<global::G.BatchError> errors,
            global::G.BatchJobStatus status,
            int createdAt,
            int totalRequests,
            int completedRequests,
            int succeededRequests,
            int failedRequests,
            global::G.BatchJobOutObject? @object,
            object? metadata,
            global::System.Guid? outputFile,
            global::System.Guid? errorFile,
            int? startedAt,
            int? completedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputFiles = inputFiles ?? throw new global::System.ArgumentNullException(nameof(inputFiles));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.TotalRequests = totalRequests;
            this.CompletedRequests = completedRequests;
            this.SucceededRequests = succeededRequests;
            this.FailedRequests = failedRequests;
            this.Object = @object;
            this.Metadata = metadata;
            this.OutputFile = outputFile;
            this.ErrorFile = errorFile;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobOut" /> class.
        /// </summary>
        public BatchJobOut()
        {
        }
    }
}