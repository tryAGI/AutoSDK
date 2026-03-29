//HintName: G.Models.Timeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A timeline represents the contents of a video edit over time, an audio edit over time, in seconds, or an image layout. A timeline consists of layers called tracks. Tracks are composed of titles, images, audio, html or video segments referred to as clips which are placed along the track at specific starting point and lasting for a specific amount of time.
    /// </summary>
    public sealed partial class Timeline
    {
        /// <summary>
        /// A music or audio file in mp3 format that plays for the duration of the rendered video or the length of the audio file, which ever is shortest.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soundtrack")]
        public global::G.Soundtrack? Soundtrack { get; set; }

        /// <summary>
        /// A hexadecimal value for the timeline background colour. Defaults to #000000 (black).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public string? Background { get; set; }

        /// <summary>
        /// An array of custom fonts to be downloaded for use by the HTML assets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fonts")]
        public global::System.Collections.Generic.IList<global::G.Font>? Fonts { get; set; }

        /// <summary>
        /// A timeline consists of an array of tracks, each track containing clips. Tracks are layered on top of each other in the same order they are added to the array with the top most track layered over the top of those below it. Ensure that a track containing titles is the top most track so that it is displayed above videos and images.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tracks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Track> Tracks { get; set; } = default!;

        /// <summary>
        /// Disable the caching of ingested source footage and assets. See  [caching](https://shotstack.io/docs/guide/architecting-an-application/caching/) for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache")]
        public bool? Cache { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Timeline" /> class.
        /// </summary>
        /// <param name="tracks">
        /// A timeline consists of an array of tracks, each track containing clips. Tracks are layered on top of each other in the same order they are added to the array with the top most track layered over the top of those below it. Ensure that a track containing titles is the top most track so that it is displayed above videos and images.
        /// </param>
        /// <param name="soundtrack">
        /// A music or audio file in mp3 format that plays for the duration of the rendered video or the length of the audio file, which ever is shortest.
        /// </param>
        /// <param name="background">
        /// A hexadecimal value for the timeline background colour. Defaults to #000000 (black).
        /// </param>
        /// <param name="fonts">
        /// An array of custom fonts to be downloaded for use by the HTML assets.
        /// </param>
        /// <param name="cache">
        /// Disable the caching of ingested source footage and assets. See  [caching](https://shotstack.io/docs/guide/architecting-an-application/caching/) for more details.
        /// </param>
        public Timeline(
            global::System.Collections.Generic.IList<global::G.Track> tracks,
            global::G.Soundtrack? soundtrack,
            string? background,
            global::System.Collections.Generic.IList<global::G.Font>? fonts,
            bool? cache)
        {
            this.Soundtrack = soundtrack;
            this.Background = background;
            this.Fonts = fonts;
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
            this.Cache = cache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timeline" /> class.
        /// </summary>
        public Timeline()
        {
        }
    }
}