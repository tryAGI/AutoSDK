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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_language", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceLanguage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DubbingMediaReference Background { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("foreground", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DubbingMediaReference Foreground { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_tracks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.SpeakerTrack> SpeakerTracks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.SpeakerSegment> SpeakerSegments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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