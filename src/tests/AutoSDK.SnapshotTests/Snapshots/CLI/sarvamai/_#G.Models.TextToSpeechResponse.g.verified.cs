//HintName: G.Models.TextToSpeechResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechResponse
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Base64-encoded audio files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audios")]
        public global::System.Collections.Generic.IList<string>? Audios { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier
        /// </param>
        /// <param name="audios">
        /// Base64-encoded audio files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechResponse(
            string? requestId,
            global::System.Collections.Generic.IList<string>? audios)
        {
            this.RequestId = requestId;
            this.Audios = audios;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechResponse" /> class.
        /// </summary>
        public TextToSpeechResponse()
        {
        }
    }
}