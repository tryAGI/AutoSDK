//HintName: G.Models.SpeakerSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.DubbedSegment> Dubs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerSegment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="text"></param>
        /// <param name="dubs"></param>
        public SpeakerSegment(
            string id,
            double startTime,
            double endTime,
            string text,
            global::System.Collections.Generic.Dictionary<string, global::G.DubbedSegment> dubs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Dubs = dubs ?? throw new global::System.ArgumentNullException(nameof(dubs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerSegment" /> class.
        /// </summary>
        public SpeakerSegment()
        {
        }
    }
}