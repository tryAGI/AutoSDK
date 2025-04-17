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
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletedRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("failed_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Default Value: batch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.BatchJobOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_file")]
        public global::System.Guid? OutputFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("succeeded_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int SucceededRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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