//HintName: G.Models.DubbingMetadataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingMetadataResponse
    {
        /// <summary>
        /// The ID of the dubbing project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubbing_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DubbingId { get; set; } = default!;

        /// <summary>
        /// The name of the dubbing project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The status of the dubbing project. Either 'dubbed', 'dubbing' or 'failed'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The target languages of the dubbing project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_metadata")]
        public global::G.DubbingMediaMetadata? MediaMetadata { get; set; }

        /// <summary>
        /// Optional error message if the dubbing project failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataResponse" /> class.
        /// </summary>
        /// <param name="dubbingId">
        /// The ID of the dubbing project.
        /// </param>
        /// <param name="name">
        /// The name of the dubbing project.
        /// </param>
        /// <param name="status">
        /// The status of the dubbing project. Either 'dubbed', 'dubbing' or 'failed'.
        /// </param>
        /// <param name="targetLanguages">
        /// The target languages of the dubbing project.
        /// </param>
        /// <param name="mediaMetadata"></param>
        /// <param name="error">
        /// Optional error message if the dubbing project failed.
        /// </param>
        public DubbingMetadataResponse(
            string dubbingId,
            string name,
            string status,
            global::System.Collections.Generic.IList<string> targetLanguages,
            global::G.DubbingMediaMetadata? mediaMetadata,
            string? error)
        {
            this.DubbingId = dubbingId ?? throw new global::System.ArgumentNullException(nameof(dubbingId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.MediaMetadata = mediaMetadata;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataResponse" /> class.
        /// </summary>
        public DubbingMetadataResponse()
        {
        }
    }
}