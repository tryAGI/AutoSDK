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
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Uploaded audio file detected metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AudioUploadMetadataDTO AudioMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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