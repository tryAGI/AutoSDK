//HintName: G.Models.CreateDubbingJobWithProjectIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingJobWithProjectIdRequest
    {
        /// <summary>
        /// The file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Your Project Id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriorityJsonConverter))]
        public global::G.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingJobWithProjectIdRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Your Project Id
        /// </param>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="fileUrl"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="fileName"></param>
        /// <param name="priority">
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </param>
        /// <param name="webhookSecret"></param>
        public CreateDubbingJobWithProjectIdRequest(
            string projectId,
            byte[]? file,
            string? fileUrl,
            string? webhookUrl,
            string? fileName,
            global::G.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority? priority,
            string? webhookSecret)
        {
            this.File = file;
            this.FileUrl = fileUrl;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.WebhookUrl = webhookUrl;
            this.FileName = fileName;
            this.Priority = priority;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingJobWithProjectIdRequest" /> class.
        /// </summary>
        public CreateDubbingJobWithProjectIdRequest()
        {
        }
    }
}