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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageCompletionsResultObjectJsonConverter))]
        public global::G.UsageCompletionsResultObject Object { get; set; }

        /// <summary>
        /// The aggregated number of text input tokens used, including cached tokens. For customers subscribe to scale tier, this includes scale tier tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The aggregated number of text input tokens that has been cached from previous requests. For customers subscribe to scale tier, this includes scale tier tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_tokens")]
        public int? InputCachedTokens { get; set; }

        /// <summary>
        /// The aggregated number of text output tokens used. For customers subscribe to scale tier, this includes scale tier tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// The aggregated number of audio input tokens used, including cached tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_tokens")]
        public int? InputAudioTokens { get; set; }

        /// <summary>
        /// The aggregated number of audio output tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_tokens")]
        public int? OutputAudioTokens { get; set; }

        /// <summary>
        /// The count of requests made to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_model_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumModelRequests { get; set; }

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// When `group_by=model`, this field provides the model name of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// When `group_by=batch`, this field tells whether the grouped usage result is batch or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public bool? Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCompletionsResult" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="inputTokens">
        /// The aggregated number of text input tokens used, including cached tokens. For customers subscribe to scale tier, this includes scale tier tokens.
        /// </param>
        /// <param name="inputCachedTokens">
        /// The aggregated number of text input tokens that has been cached from previous requests. For customers subscribe to scale tier, this includes scale tier tokens.
        /// </param>
        /// <param name="outputTokens">
        /// The aggregated number of text output tokens used. For customers subscribe to scale tier, this includes scale tier tokens.
        /// </param>
        /// <param name="inputAudioTokens">
        /// The aggregated number of audio input tokens used, including cached tokens.
        /// </param>
        /// <param name="outputAudioTokens">
        /// The aggregated number of audio output tokens used.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCompletionsResult(
            int inputTokens,
            int outputTokens,
            int numModelRequests,
            global::G.UsageCompletionsResultObject @object,
            int? inputCachedTokens,
            int? inputAudioTokens,
            int? outputAudioTokens,
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
            this.InputAudioTokens = inputAudioTokens;
            this.OutputAudioTokens = outputAudioTokens;
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