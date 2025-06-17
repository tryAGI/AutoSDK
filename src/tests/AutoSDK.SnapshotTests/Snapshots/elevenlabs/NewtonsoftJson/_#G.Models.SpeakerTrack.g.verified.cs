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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DubbingMediaReference MediaRef { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpeakerName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Voices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Segments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerTrack" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mediaRef"></param>
        /// <param name="speakerName"></param>
        /// <param name="voices"></param>
        /// <param name="segments"></param>
        public SpeakerTrack(
            string id,
            global::G.DubbingMediaReference mediaRef,
            string speakerName,
            global::System.Collections.Generic.Dictionary<string, string> voices,
            global::System.Collections.Generic.IList<string> segments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MediaRef = mediaRef ?? throw new global::System.ArgumentNullException(nameof(mediaRef));
            this.SpeakerName = speakerName ?? throw new global::System.ArgumentNullException(nameof(speakerName));
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
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