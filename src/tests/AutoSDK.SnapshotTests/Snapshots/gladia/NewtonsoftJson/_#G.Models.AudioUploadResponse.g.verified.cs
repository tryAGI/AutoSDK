//HintName: G.Models.AudioUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioUploadResponse
    {
        /// <summary>
        /// Uploaded audio file Gladia URL<br/>
        /// Example: https://api.gladia.io/file/6c09400e-23d2-4bd2-be55-96a5ececfa3b
        /// </summary>
        /// <example>https://api.gladia.io/file/6c09400e-23d2-4bd2-be55-96a5ececfa3b</example>
        [global::Newtonsoft.Json.JsonProperty("audio_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioUrl { get; set; } = default!;

        /// <summary>
        /// Uploaded audio file detected metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AudioUploadMetadataDTO AudioMetadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUploadResponse" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// Uploaded audio file Gladia URL<br/>
        /// Example: https://api.gladia.io/file/6c09400e-23d2-4bd2-be55-96a5ececfa3b
        /// </param>
        /// <param name="audioMetadata">
        /// Uploaded audio file detected metadata
        /// </param>
        public AudioUploadResponse(
            string audioUrl,
            global::G.AudioUploadMetadataDTO audioMetadata)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.AudioMetadata = audioMetadata ?? throw new global::System.ArgumentNullException(nameof(audioMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUploadResponse" /> class.
        /// </summary>
        public AudioUploadResponse()
        {
        }
    }
}