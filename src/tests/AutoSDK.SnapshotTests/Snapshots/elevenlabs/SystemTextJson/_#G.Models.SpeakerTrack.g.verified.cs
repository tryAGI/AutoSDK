//HintName: G.Models.SpeakerTrack.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerTrack
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
        [global::System.Text.Json.Serialization.JsonPropertyName("media_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingMediaReference MediaRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeakerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerTrack" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mediaRef"></param>
        /// <param name="speakerName"></param>
        /// <param name="segments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerTrack(
            string id,
            global::G.DubbingMediaReference mediaRef,
            string speakerName,
            global::System.Collections.Generic.IList<string> segments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MediaRef = mediaRef ?? throw new global::System.ArgumentNullException(nameof(mediaRef));
            this.SpeakerName = speakerName ?? throw new global::System.ArgumentNullException(nameof(speakerName));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerTrack" /> class.
        /// </summary>
        public SpeakerTrack()
        {
        }
    }
}