//HintName: G.Models.ApiJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Dubbing Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubbing_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiJobResponseDubbingType DubbingType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Your Uploaded File Name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiJobResponsePriority Priority { get; set; } = default!;

        /// <summary>
        /// Source locale
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_locale")]
        public string? SourceLocale { get; set; }

        /// <summary>
        /// Your Job Id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// List of target locales
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_locales", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TargetLocales { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiJobResponse" /> class.
        /// </summary>
        /// <param name="dubbingType">
        /// Dubbing Type
        /// </param>
        /// <param name="fileName">
        /// Your Uploaded File Name
        /// </param>
        /// <param name="priority">
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </param>
        /// <param name="jobId">
        /// Your Job Id
        /// </param>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="fileUrl"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="sourceLocale">
        /// Source locale
        /// </param>
        /// <param name="warning"></param>
        public ApiJobResponse(
            global::G.ApiJobResponseDubbingType dubbingType,
            string fileName,
            global::G.ApiJobResponsePriority priority,
            string jobId,
            global::System.Collections.Generic.IList<string> targetLocales,
            string? fileUrl,
            string? webhookUrl,
            string? sourceLocale,
            string? warning)
        {
            this.FileUrl = fileUrl;
            this.DubbingType = dubbingType;
            this.WebhookUrl = webhookUrl;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.Priority = priority;
            this.SourceLocale = sourceLocale;
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.TargetLocales = targetLocales ?? throw new global::System.ArgumentNullException(nameof(targetLocales));
            this.Warning = warning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiJobResponse" /> class.
        /// </summary>
        public ApiJobResponse()
        {
        }
    }
}