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
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack> Tracks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaMultitrackSequence" /> class.
        /// </summary>
        /// <param name="tracks">
        /// Array of tracks to combine into a multitrack sequence
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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