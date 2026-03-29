//HintName: G.Models.Track.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A track contains an array of clips. Tracks are layered on top of each other in the order in the array. The top most track will render on top of those below it.
    /// </summary>
    public sealed partial class Track
    {
        /// <summary>
        /// An array of Clips comprising of TitleClip, ImageClip or VideoClip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Clip> Clips { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        /// <param name="clips">
        /// An array of Clips comprising of TitleClip, ImageClip or VideoClip.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Track(
            global::System.Collections.Generic.IList<global::G.Clip> clips)
        {
            this.Clips = clips ?? throw new global::System.ArgumentNullException(nameof(clips));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        public Track()
        {
        }
    }
}