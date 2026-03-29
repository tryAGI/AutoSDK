//HintName: G.Models.CreateDubbingJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingJobRequest
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
        /// Source locale
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_locale")]
        public string? SourceLocale { get; set; }

        /// <summary>
        /// List of target locales
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_locales", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TargetLocales { get; set; } = default!;

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
        public global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority? Priority { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDubbingJobRequest" /> class.
        /// </summary>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="fileUrl"></param>
        /// <param name="sourceLocale">
        /// Source locale
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="fileName"></param>
        /// <param name="priority">
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </param>
        /// <param name="webhookSecret"></param>
        public CreateDubbingJobRequest(
            global::System.Collections.Generic.IList<string> targetLocales,
            byte[]? file,
            string? fileUrl,
            string? sourceLocale,
            string? webhookUrl,
            string? fileName,
            global::G.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority? priority,
            string? webhookSecret)
        {
            this.File = file;
            this.FileUrl = fileUrl;
            this.SourceLocale = sourceLocale;
            this.TargetLocales = targetLocales ?? throw new global::System.ArgumentNullException(nameof(targetLocales));
            this.WebhookUrl = webhookUrl;
            this.FileName = fileName;
            this.Priority = priority;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingJobRequest" /> class.
        /// </summary>
        public CreateDubbingJobRequest()
        {
        }
    }
}