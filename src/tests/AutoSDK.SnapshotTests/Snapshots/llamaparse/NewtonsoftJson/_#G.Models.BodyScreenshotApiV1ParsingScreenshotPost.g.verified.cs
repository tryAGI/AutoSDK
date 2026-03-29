//HintName: G.Models.BodyScreenshotApiV1ParsingScreenshotPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyScreenshotApiV1ParsingScreenshotPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do_not_cache")]
        public bool? DoNotCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("http_proxy")]
        public string? HttpProxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_s3_path")]
        public string? InputS3Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_s3_region")]
        public string? InputS3Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invalidate_cache")]
        public bool? InvalidateCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_s3_path_prefix")]
        public string? OutputS3PathPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_s3_region")]
        public string? OutputS3Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_pages")]
        public string? TargetPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_configurations")]
        public string? WebhookConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_timeout_in_seconds")]
        public double? JobTimeoutInSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_timeout_extra_time_per_page_in_seconds")]
        public double? JobTimeoutExtraTimePerPageInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyScreenshotApiV1ParsingScreenshotPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="doNotCache">
        /// Default Value: false
        /// </param>
        /// <param name="httpProxy"></param>
        /// <param name="inputS3Path"></param>
        /// <param name="inputS3Region"></param>
        /// <param name="inputUrl"></param>
        /// <param name="invalidateCache">
        /// Default Value: false
        /// </param>
        /// <param name="maxPages"></param>
        /// <param name="outputS3PathPrefix"></param>
        /// <param name="outputS3Region"></param>
        /// <param name="targetPages"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookConfigurations"></param>
        /// <param name="jobTimeoutInSeconds"></param>
        /// <param name="jobTimeoutExtraTimePerPageInSeconds"></param>
        public BodyScreenshotApiV1ParsingScreenshotPost(
            byte[]? file,
            string? filename,
            bool? doNotCache,
            string? httpProxy,
            string? inputS3Path,
            string? inputS3Region,
            string? inputUrl,
            bool? invalidateCache,
            int? maxPages,
            string? outputS3PathPrefix,
            string? outputS3Region,
            string? targetPages,
            string? webhookUrl,
            string? webhookConfigurations,
            double? jobTimeoutInSeconds,
            double? jobTimeoutExtraTimePerPageInSeconds)
        {
            this.File = file;
            this.Filename = filename;
            this.DoNotCache = doNotCache;
            this.HttpProxy = httpProxy;
            this.InputS3Path = inputS3Path;
            this.InputS3Region = inputS3Region;
            this.InputUrl = inputUrl;
            this.InvalidateCache = invalidateCache;
            this.MaxPages = maxPages;
            this.OutputS3PathPrefix = outputS3PathPrefix;
            this.OutputS3Region = outputS3Region;
            this.TargetPages = targetPages;
            this.WebhookUrl = webhookUrl;
            this.WebhookConfigurations = webhookConfigurations;
            this.JobTimeoutInSeconds = jobTimeoutInSeconds;
            this.JobTimeoutExtraTimePerPageInSeconds = jobTimeoutExtraTimePerPageInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyScreenshotApiV1ParsingScreenshotPost" /> class.
        /// </summary>
        public BodyScreenshotApiV1ParsingScreenshotPost()
        {
        }
    }
}