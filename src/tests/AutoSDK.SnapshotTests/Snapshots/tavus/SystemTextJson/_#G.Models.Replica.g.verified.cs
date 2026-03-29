//HintName: G.Models.Replica.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Replica
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_id")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_name")]
        public string? ReplicaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_type")]
        public string? ReplicaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_progress")]
        public string? TrainingProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_video_url")]
        public string? ThumbnailVideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Replica" /> class.
        /// </summary>
        /// <param name="replicaId"></param>
        /// <param name="replicaName"></param>
        /// <param name="status"></param>
        /// <param name="modelName"></param>
        /// <param name="replicaType"></param>
        /// <param name="trainingProgress"></param>
        /// <param name="thumbnailVideoUrl"></param>
        /// <param name="errorMessage"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Replica(
            string? replicaId,
            string? replicaName,
            string? status,
            string? modelName,
            string? replicaType,
            string? trainingProgress,
            string? thumbnailVideoUrl,
            string? errorMessage,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.ReplicaId = replicaId;
            this.ReplicaName = replicaName;
            this.Status = status;
            this.ModelName = modelName;
            this.ReplicaType = replicaType;
            this.TrainingProgress = trainingProgress;
            this.ThumbnailVideoUrl = thumbnailVideoUrl;
            this.ErrorMessage = errorMessage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Replica" /> class.
        /// </summary>
        public Replica()
        {
        }
    }
}