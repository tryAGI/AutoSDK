//HintName: G.Models.CreateReplicaRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateReplicaRequest
    {
        /// <summary>
        /// Publicly accessible download link to the training video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_video_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainVideoUrl { get; set; } = default!;

        /// <summary>
        /// Publicly accessible download link to the consent video. Required for personal replicas.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consent_video_url")]
        public string? ConsentVideoUrl { get; set; }

        /// <summary>
        /// Name for the replica.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replica_name")]
        public string? ReplicaName { get; set; }

        /// <summary>
        /// URL to receive training status callbacks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Model to use (defaults to phoenix-4).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public global::G.CreateReplicaRequestModelName? ModelName { get; set; }

        /// <summary>
        /// The type of replica.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replica_type")]
        public global::G.CreateReplicaRequestReplicaType? ReplicaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_audio_url")]
        public string? TrainAudioUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_video_url")]
        public string? ThumbnailVideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReplicaRequest" /> class.
        /// </summary>
        /// <param name="trainVideoUrl">
        /// Publicly accessible download link to the training video.
        /// </param>
        /// <param name="consentVideoUrl">
        /// Publicly accessible download link to the consent video. Required for personal replicas.
        /// </param>
        /// <param name="replicaName">
        /// Name for the replica.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive training status callbacks.
        /// </param>
        /// <param name="modelName">
        /// Model to use (defaults to phoenix-4).
        /// </param>
        /// <param name="replicaType">
        /// The type of replica.
        /// </param>
        /// <param name="trainAudioUrl"></param>
        /// <param name="thumbnailVideoUrl"></param>
        public CreateReplicaRequest(
            string trainVideoUrl,
            string? consentVideoUrl,
            string? replicaName,
            string? callbackUrl,
            global::G.CreateReplicaRequestModelName? modelName,
            global::G.CreateReplicaRequestReplicaType? replicaType,
            string? trainAudioUrl,
            string? thumbnailVideoUrl)
        {
            this.TrainVideoUrl = trainVideoUrl ?? throw new global::System.ArgumentNullException(nameof(trainVideoUrl));
            this.ConsentVideoUrl = consentVideoUrl;
            this.ReplicaName = replicaName;
            this.CallbackUrl = callbackUrl;
            this.ModelName = modelName;
            this.ReplicaType = replicaType;
            this.TrainAudioUrl = trainAudioUrl;
            this.ThumbnailVideoUrl = thumbnailVideoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReplicaRequest" /> class.
        /// </summary>
        public CreateReplicaRequest()
        {
        }
    }
}