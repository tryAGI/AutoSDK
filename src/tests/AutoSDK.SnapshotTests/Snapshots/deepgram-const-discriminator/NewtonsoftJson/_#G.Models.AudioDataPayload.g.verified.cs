//HintName: G.Models.AudioDataPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio data sent for transcription.
    /// </summary>
    public sealed partial class AudioDataPayload
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"audio_data"</default>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string MessageType { get; set; } = "audio_data";

        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_base_64", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioBase64 { get; set; } = default!;

        /// <summary>
        /// Audio sample rate in Hz.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDataPayload" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz.
        /// </param>
        /// <param name="messageType"></param>
        public AudioDataPayload(
            string audioBase64,
            int? sampleRate,
            string messageType = "audio_data")
        {
            this.MessageType = messageType;
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDataPayload" /> class.
        /// </summary>
        public AudioDataPayload()
        {
        }
    }
}