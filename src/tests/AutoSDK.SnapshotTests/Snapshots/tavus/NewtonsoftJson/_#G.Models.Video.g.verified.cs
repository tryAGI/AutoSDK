//HintName: G.Models.Video.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Video
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id")]
        public string? VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_name")]
        public string? VideoName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replica_id")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script")]
        public string? Script { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_url")]
        public string? StreamUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hosted_url")]
        public string? HostedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_details")]
        public string? StatusDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="videoName"></param>
        /// <param name="status"></param>
        /// <param name="replicaId"></param>
        /// <param name="script"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="streamUrl"></param>
        /// <param name="hostedUrl"></param>
        /// <param name="errorMessage"></param>
        /// <param name="statusDetails"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public Video(
            string? videoId,
            string? videoName,
            string? status,
            string? replicaId,
            string? script,
            string? downloadUrl,
            string? streamUrl,
            string? hostedUrl,
            string? errorMessage,
            string? statusDetails,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.VideoId = videoId;
            this.VideoName = videoName;
            this.Status = status;
            this.ReplicaId = replicaId;
            this.Script = script;
            this.DownloadUrl = downloadUrl;
            this.StreamUrl = streamUrl;
            this.HostedUrl = hostedUrl;
            this.ErrorMessage = errorMessage;
            this.StatusDetails = statusDetails;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        public Video()
        {
        }
    }
}