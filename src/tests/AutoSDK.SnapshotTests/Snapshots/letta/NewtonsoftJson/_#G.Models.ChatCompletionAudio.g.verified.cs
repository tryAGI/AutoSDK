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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpiresAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAudio" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="expiresAt"></param>
        /// <param name="transcript"></param>
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