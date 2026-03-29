//HintName: G.Models.ImportProjectMediaRequestAddMediaMultitrackSequence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a multitrack sequence from multiple media files
    /// </summary>
    public sealed partial class ImportProjectMediaRequestAddMediaMultitrackSequence
    {
        /// <summary>
        /// Array of tracks to combine into a multitrack sequence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tracks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack> Tracks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaMultitrackSequence" /> class.
        /// </summary>
        /// <param name="tracks">
        /// Array of tracks to combine into a multitrack sequence
        /// </param>
        public ImportProjectMediaRequestAddMediaMultitrackSequence(
            global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack> tracks)
        {
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaMultitrackSequence" /> class.
        /// </summary>
        public ImportProjectMediaRequestAddMediaMultitrackSequence()
        {
        }
    }
}