//HintName: G.Models.UsageImagesResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated images usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageImagesResult
    {
        /// <summary>
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// The number of images processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Images { get; set; }

        /// <summary>
        /// When `group_by=model`, this field provides the model name of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The count of requests made to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_model_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumModelRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageImagesResultObjectJsonConverter))]
        public global::G.UsageImagesResultObject Object { get; set; }

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// When `group_by=size`, this field provides the image size of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// When `group_by=source`, this field provides the source of the grouped usage result, possible values are `image.generation`, `image.edit`, `image.variation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageImagesResult" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// When `group_by=api_key_id`, this field provides the API key ID of the grouped usage result.
        /// </param>
        /// <param name="images">
        /// The number of images processed.
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
        /// <param name="size">
        /// When `group_by=size`, this field provides the image size of the grouped usage result.
        /// </param>
        /// <param name="source">
        /// When `group_by=source`, this field provides the source of the grouped usage result, possible values are `image.generation`, `image.edit`, `image.variation`.
        /// </param>
        /// <param name="userId">
        /// When `group_by=user_id`, this field provides the user ID of the grouped usage result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageImagesResult(
            int images,
            int numModelRequests,
            string? apiKeyId,
            string? model,
            global::G.UsageImagesResultObject @object,
            string? projectId,
            string? size,
            string? source,
            string? userId)
        {
            this.Images = images;
            this.NumModelRequests = numModelRequests;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
            this.Object = @object;
            this.ProjectId = projectId;
            this.Size = size;
            this.Source = source;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageImagesResult" /> class.
        /// </summary>
        public UsageImagesResult()
        {
        }
    }
}