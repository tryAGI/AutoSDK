//HintName: G.Models.ChatCompletionAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If the audio output modality is requested, this object contains data<br/>
    /// about the audio response from the model. [Learn more](https://platform.openai.com/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAudio" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="expiresAt"></param>
        /// <param name="transcript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAudio(
            string id,
            string data,
            int expiresAt,
            string transcript)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.ExpiresAt = expiresAt;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAudio" /> class.
        /// </summary>
        public ChatCompletionAudio()
        {
        }
    }
}