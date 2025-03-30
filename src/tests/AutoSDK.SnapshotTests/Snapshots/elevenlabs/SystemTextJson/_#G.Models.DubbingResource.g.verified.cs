//HintName: G.Models.DubbingResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingResource
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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetLanguages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingMediaReference Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingMediaReference Foreground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.SpeakerTrack> SpeakerTracks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.SpeakerSegment> SpeakerSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="sourceLanguage"></param>
        /// <param name="targetLanguages"></param>
        /// <param name="background"></param>
        /// <param name="foreground"></param>
        /// <param name="speakerTracks"></param>
        /// <param name="speakerSegments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingResource(
            string id,
            int version,
            string sourceLanguage,
            global::System.Collections.Generic.IList<string> targetLanguages,
            global::G.DubbingMediaReference background,
            global::G.DubbingMediaReference foreground,
            global::System.Collections.Generic.Dictionary<string, global::G.SpeakerTrack> speakerTracks,
            global::System.Collections.Generic.Dictionary<string, global::G.SpeakerSegment> speakerSegments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.SourceLanguage = sourceLanguage ?? throw new global::System.ArgumentNullException(nameof(sourceLanguage));
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.Background = background ?? throw new global::System.ArgumentNullException(nameof(background));
            this.Foreground = foreground ?? throw new global::System.ArgumentNullException(nameof(foreground));
            this.SpeakerTracks = speakerTracks ?? throw new global::System.ArgumentNullException(nameof(speakerTracks));
            this.SpeakerSegments = speakerSegments ?? throw new global::System.ArgumentNullException(nameof(speakerSegments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingResource" /> class.
        /// </summary>
        public DubbingResource()
        {
        }
    }
}