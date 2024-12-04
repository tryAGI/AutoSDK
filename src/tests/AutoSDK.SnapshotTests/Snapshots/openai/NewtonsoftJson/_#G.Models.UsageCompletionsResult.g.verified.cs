//HintName: G.Models.UsageCompletionsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated completions usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageCompletionsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UsageCompletionsResultObject Object { get; set; }

        /// <summary>
        /// The number of input tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// The number of input tokens that has been cached from previous requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_cached_tokens")]
        public int? InputCachedTokens { get; set; }

        /// <summary>
        /// The number of output tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// The count of requests made to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_model_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumModelRequests { get; set; } = default!;

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

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
        /// When `group_by=batch`, this field tells whether the grouped usage result is batch or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch")]
        public bool? Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCompletionsResult" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="inputTokens">
        /// The number of input tokens used.
        /// </param>
        /// <param name="inputCachedTokens">
        /// The number of input tokens that has been cached from previous requests.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens used.
        /// </param>
        /// <param name="numModelRequests">
        /// The count of requests made to the model.
        /// </param>
        /// <param name="projectId">
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </param>
        /// <param name="userId">
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </param>
        /// <param name="apiKeyId">
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </param>
        /// <param name="model">
        /// When `group_by=model`, this field provides the model name of the grouped usage result.
        /// </param>
        /// <param name="batch">
        /// When `group_by=batch`, this field tells whether the grouped usage result is batch or not.
        /// </param>
        public UsageCompletionsResult(
            int inputTokens,
            int outputTokens,
            int numModelRequests,
            global::G.UsageCompletionsResultObject @object,
            int? inputCachedTokens,
            string? projectId,
            string? userId,
            string? apiKeyId,
            string? model,
            bool? batch)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.NumModelRequests = numModelRequests;
            this.Object = @object;
            this.InputCachedTokens = inputCachedTokens;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
            this.Batch = batch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCompletionsResult" /> class.
        /// </summary>
        public UsageCompletionsResult()
        {
        }
    }
}