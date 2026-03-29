//HintName: G.Models.AudioSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the audio embedding and its start time.
    /// </summary>
    public sealed partial class AudioSegment
    {
        /// <summary>
        /// An array of floating point numbers representing the embedding. You can use this array with cosine similarity for various downstream tasks. Note that the example response was truncated for brevity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("float")]
        public global::System.Collections.Generic.IList<double>? Float { get; set; }

        /// <summary>
        /// The start time in seconds from the beginning of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_offset_sec")]
        public double? StartOffsetSec { get; set; }

        /// <summary>
        /// The end time in seconds from the beginning of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_offset_sec")]
        public double? EndOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegment" /> class.
        /// </summary>
        /// <param name="float">
        /// An array of floating point numbers representing the embedding. You can use this array with cosine similarity for various downstream tasks. Note that the example response was truncated for brevity.
        /// </param>
        /// <param name="startOffsetSec">
        /// The start time in seconds from the beginning of the file.
        /// </param>
        /// <param name="endOffsetSec">
        /// The end time in seconds from the beginning of the file.
        /// </param>
        public AudioSegment(
            global::System.Collections.Generic.IList<double>? @float,
            double? startOffsetSec,
            double? endOffsetSec)
        {
            this.Float = @float;
            this.StartOffsetSec = startOffsetSec;
            this.EndOffsetSec = endOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegment" /> class.
        /// </summary>
        public AudioSegment()
        {
        }
    }
}