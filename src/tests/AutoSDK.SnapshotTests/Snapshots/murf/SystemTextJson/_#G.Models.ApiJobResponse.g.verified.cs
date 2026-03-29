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
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Dubbing Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiJobResponseDubbingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiJobResponseDubbingType DubbingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Your Uploaded File Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiJobResponsePriorityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiJobResponsePriority Priority { get; set; }

        /// <summary>
        /// Source locale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_locale")]
        public string? SourceLocale { get; set; }

        /// <summary>
        /// Your Job Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// List of target locales
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_locales")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetLocales { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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