//HintName: G.Models.BulkEmbeddingJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"000000000000000000000000","model_name":"model_1","status":"in-progress","file_name":"input.csv","used_token_count":1000}
    /// </summary>
    public sealed partial class BulkEmbeddingJobResponse
    {
        /// <summary>
        /// The user ID of the user who created the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The name of the model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The model package ARN
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_package_arn")]
        public string? ModelPackageArn { get; set; }

        /// <summary>
        /// The status of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BulkEmbeddingJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BulkEmbeddingJobStatus Status { get; set; }

        /// <summary>
        /// The name of the input file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The email of the user who created the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Time of creation of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Time of completion of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The error message of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The ID of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The number of tokens used for the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_token_count")]
        public int? UsedTokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkEmbeddingJobResponse" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user ID of the user who created the job
        /// </param>
        /// <param name="modelName">
        /// The name of the model to use
        /// </param>
        /// <param name="modelPackageArn">
        /// The model package ARN
        /// </param>
        /// <param name="status">
        /// The status of the job
        /// </param>
        /// <param name="fileName">
        /// The name of the input file
        /// </param>
        /// <param name="userEmail">
        /// The email of the user who created the job
        /// </param>
        /// <param name="createdAt">
        /// Time of creation of the job.
        /// </param>
        /// <param name="completedAt">
        /// Time of completion of the job.
        /// </param>
        /// <param name="error">
        /// The error message of the job
        /// </param>
        /// <param name="id">
        /// The ID of the job
        /// </param>
        /// <param name="usedTokenCount">
        /// The number of tokens used for the job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkEmbeddingJobResponse(
            string userId,
            string modelName,
            global::G.BulkEmbeddingJobStatus status,
            string fileName,
            string id,
            string? modelPackageArn,
            string? userEmail,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? error,
            int? usedTokenCount)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Status = status;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ModelPackageArn = modelPackageArn;
            this.UserEmail = userEmail;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Error = error;
            this.UsedTokenCount = usedTokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkEmbeddingJobResponse" /> class.
        /// </summary>
        public BulkEmbeddingJobResponse()
        {
        }
    }
}