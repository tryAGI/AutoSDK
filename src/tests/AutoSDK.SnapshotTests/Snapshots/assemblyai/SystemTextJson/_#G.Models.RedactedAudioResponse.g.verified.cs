//HintName: G.Models.RedactedAudioResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RedactedAudioResponse
    {
        /// <summary>
        /// The status of the redacted audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RedactedAudioStatusJsonConverter))]
        public global::G.RedactedAudioStatus Status { get; set; }

        /// <summary>
        /// The URL of the redacted audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedAudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedAudioResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the redacted audio
        /// </param>
        /// <param name="redactedAudioUrl">
        /// The URL of the redacted audio file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedactedAudioResponse(
            string redactedAudioUrl,
            global::G.RedactedAudioStatus status)
        {
            this.RedactedAudioUrl = redactedAudioUrl ?? throw new global::System.ArgumentNullException(nameof(redactedAudioUrl));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedAudioResponse" /> class.
        /// </summary>
        public RedactedAudioResponse()
        {
        }
    }
}