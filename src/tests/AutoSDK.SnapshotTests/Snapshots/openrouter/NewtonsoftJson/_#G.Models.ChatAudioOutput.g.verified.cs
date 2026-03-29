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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Audio expiration timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Audio transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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