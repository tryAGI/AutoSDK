//HintName: G.Models.ChatAudioOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio output data or reference
    /// </summary>
    public sealed partial class ChatAudioOutput
    {
        /// <summary>
        /// Audio output identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Audio expiration timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Audio transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAudioOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// Audio output identifier
        /// </param>
        /// <param name="expiresAt">
        /// Audio expiration timestamp
        /// </param>
        /// <param name="data">
        /// Base64 encoded audio data
        /// </param>
        /// <param name="transcript">
        /// Audio transcript
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAudioOutput(
            string? id,
            double? expiresAt,
            string? data,
            string? transcript)
        {
            this.Id = id;
            this.ExpiresAt = expiresAt;
            this.Data = data;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAudioOutput" /> class.
        /// </summary>
        public ChatAudioOutput()
        {
        }
    }
}