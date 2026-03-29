//HintName: G.Models.TimestampSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimestampSegment
    {
        /// <summary>
        /// Start time of the segment in seconds from the beginning of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// End time of the segment in seconds from the beginning of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// The transcribed word or phrase for this time segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampSegment" /> class.
        /// </summary>
        /// <param name="start">
        /// Start time of the segment in seconds from the beginning of the audio.
        /// </param>
        /// <param name="end">
        /// End time of the segment in seconds from the beginning of the audio.
        /// </param>
        /// <param name="transcript">
        /// The transcribed word or phrase for this time segment.
        /// </param>
        public TimestampSegment(
            double start,
            double end,
            string transcript)
        {
            this.Start = start;
            this.End = end;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampSegment" /> class.
        /// </summary>
        public TimestampSegment()
        {
        }
    }
}