//HintName: G.Models.AudioChunkAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioChunkAction
    {
        /// <summary>
        /// Default Value: audio_chunk<br/>
        /// Example: audio_chunk
        /// </summary>
        /// <default>global::G.AudioChunkActionType.AudioChunk</default>
        /// <example>audio_chunk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioChunkActionTypeJsonConverter))]
        public global::G.AudioChunkActionType Type { get; set; } = global::G.AudioChunkActionType.AudioChunk;

        /// <summary>
        /// Payload of the audio chunk action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AudioChunkActionData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunkAction" /> class.
        /// </summary>
        /// <param name="data">
        /// Payload of the audio chunk action
        /// </param>
        /// <param name="type">
        /// Default Value: audio_chunk<br/>
        /// Example: audio_chunk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioChunkAction(
            global::G.AudioChunkActionData data,
            global::G.AudioChunkActionType type = global::G.AudioChunkActionType.AudioChunk)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunkAction" /> class.
        /// </summary>
        public AudioChunkAction()
        {
        }
    }
}