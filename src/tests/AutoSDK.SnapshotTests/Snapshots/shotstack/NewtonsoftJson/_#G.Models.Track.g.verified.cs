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
        [global::Newtonsoft.Json.JsonProperty("clips", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Clip> Clips { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        /// <param name="clips">
        /// An array of Clips comprising of TitleClip, ImageClip or VideoClip.
        /// </param>
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