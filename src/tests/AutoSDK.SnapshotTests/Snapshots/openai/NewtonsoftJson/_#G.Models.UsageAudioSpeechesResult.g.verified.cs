//HintName: G.Models.UsageAudioSpeechesResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated audio speeches usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageAudioSpeechesResult
    {
        /// <summary>
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// The number of characters processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters", Required = global::Newtonsoft.Json.Required.Always)]
        public int Characters { get; set; } = default!;

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
        public global::G.UsageAudioSpeechesResultObject Object { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAudioSpeechesResult" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </param>
        /// <param name="characters">
        /// The number of characters processed.
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
        /// <param name="userId">
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </param>
        public UsageAudioSpeechesResult(
            int characters,
            int numModelRequests,
            string? apiKeyId,
            string? model,
            global::G.UsageAudioSpeechesResultObject @object,
            string? projectId,
            string? userId)
        {
            this.Characters = characters;
            this.NumModelRequests = numModelRequests;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
            this.Object = @object;
            this.ProjectId = projectId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAudioSpeechesResult" /> class.
        /// </summary>
        public UsageAudioSpeechesResult()
        {
        }
    }
}