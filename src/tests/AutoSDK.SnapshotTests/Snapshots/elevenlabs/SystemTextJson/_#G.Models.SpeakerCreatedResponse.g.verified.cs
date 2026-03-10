//HintName: G.Models.SpeakerCreatedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerCreatedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeakerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerCreatedResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="speakerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerCreatedResponse(
            int version,
            string speakerId)
        {
            this.Version = version;
            this.SpeakerId = speakerId ?? throw new global::System.ArgumentNullException(nameof(speakerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerCreatedResponse" /> class.
        /// </summary>
        public SpeakerCreatedResponse()
        {
        }
    }
}