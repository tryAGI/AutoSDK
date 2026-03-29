//HintName: G.Models.Range.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify a time range to render, i.e. to render only a portion of a video or audio file. Omit this setting to  export the entire video. Range can also be used to render a frame at a specific time point - setting a range and output format as `jpg` will output a single frame image at the range `start` point.
    /// </summary>
    public sealed partial class Range
    {
        /// <summary>
        /// The point on the timeline, in seconds, to start the render from - i.e. start at second 3.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public float? Start { get; set; }

        /// <summary>
        /// The length of the portion of the video or audio to render - i.e. render 6 seconds of the video.<br/>
        /// Example: 6
        /// </summary>
        /// <example>6</example>
        [global::Newtonsoft.Json.JsonProperty("length")]
        public float? Length { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        /// <param name="start">
        /// The point on the timeline, in seconds, to start the render from - i.e. start at second 3.<br/>
        /// Example: 3
        /// </param>
        /// <param name="length">
        /// The length of the portion of the video or audio to render - i.e. render 6 seconds of the video.<br/>
        /// Example: 6
        /// </param>
        public Range(
            float? start,
            float? length)
        {
            this.Start = start;
            this.Length = length;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        public Range()
        {
        }
    }
}