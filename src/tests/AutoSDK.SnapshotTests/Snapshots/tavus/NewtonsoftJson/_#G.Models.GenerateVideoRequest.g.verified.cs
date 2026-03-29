//HintName: G.Models.GenerateVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateVideoRequest
    {
        /// <summary>
        /// The replica to use for the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replica_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReplicaId { get; set; } = default!;

        /// <summary>
        /// Text for the replica to speak.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script")]
        public string? Script { get; set; }

        /// <summary>
        /// Audio file URL (.wav or .mp3) for lip-sync.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_name")]
        public string? VideoName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Website URL for background.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_url")]
        public string? BackgroundUrl { get; set; }

        /// <summary>
        /// Direct download link for video background.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_source_url")]
        public string? BackgroundSourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transparent_background")]
        public bool? TransparentBackground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::G.VideoProperties? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoRequest" /> class.
        /// </summary>
        /// <param name="replicaId">
        /// The replica to use for the video.
        /// </param>
        /// <param name="script">
        /// Text for the replica to speak.
        /// </param>
        /// <param name="audioUrl">
        /// Audio file URL (.wav or .mp3) for lip-sync.
        /// </param>
        /// <param name="videoName"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="backgroundUrl">
        /// Website URL for background.
        /// </param>
        /// <param name="backgroundSourceUrl">
        /// Direct download link for video background.
        /// </param>
        /// <param name="transparentBackground"></param>
        /// <param name="properties"></param>
        public GenerateVideoRequest(
            string replicaId,
            string? script,
            string? audioUrl,
            string? videoName,
            string? callbackUrl,
            string? backgroundUrl,
            string? backgroundSourceUrl,
            bool? transparentBackground,
            global::G.VideoProperties? properties)
        {
            this.ReplicaId = replicaId ?? throw new global::System.ArgumentNullException(nameof(replicaId));
            this.Script = script;
            this.AudioUrl = audioUrl;
            this.VideoName = videoName;
            this.CallbackUrl = callbackUrl;
            this.BackgroundUrl = backgroundUrl;
            this.BackgroundSourceUrl = backgroundSourceUrl;
            this.TransparentBackground = transparentBackground;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoRequest" /> class.
        /// </summary>
        public GenerateVideoRequest()
        {
        }
    }
}