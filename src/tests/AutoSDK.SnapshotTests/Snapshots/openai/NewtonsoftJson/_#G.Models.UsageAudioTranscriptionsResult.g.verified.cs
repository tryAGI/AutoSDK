//HintName: G.Models.UsageAudioTranscriptionsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated audio transcriptions usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageAudioTranscriptionsResult
    {
        /// <summary>
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// When `group_by=model`, this field provides the model name of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The count of requests made to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_model_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumModelRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UsageAudioTranscriptionsResultObject Object { get; set; }

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The number of seconds processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public int Seconds { get; set; } = default!;

        /// <summary>
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAudioTranscriptionsResult" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </param>
        /// <param name="model">
        /// When `group_by=model`, this field provides the model name of the grouped usage result.
        /// </param>
        /// <param name="numModelRequests">
        /// The count of requests made to the model.
        /// </param>
        /// <param name="object"></param>
        /// <param name="projectId">
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </param>
        /// <param name="seconds">
        /// The number of seconds processed.
        /// </param>
        /// <param name="userId">
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </param>
        public UsageAudioTranscriptionsResult(
            int numModelRequests,
            int seconds,
            string? apiKeyId,
            string? model,
            global::G.UsageAudioTranscriptionsResultObject @object,
            string? projectId,
            string? userId)
        {
            this.NumModelRequests = numModelRequests;
            this.Seconds = seconds;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
            this.Object = @object;
            this.ProjectId = projectId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAudioTranscriptionsResult" /> class.
        /// </summary>
        public UsageAudioTranscriptionsResult()
        {
        }
    }
}