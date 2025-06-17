//HintName: G.Models.SegmentCreatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentCreatePayload
    {
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
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translations")]
        public global::System.Collections.Generic.Dictionary<string, string>? Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentCreatePayload" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="text"></param>
        /// <param name="translations"></param>
        public SegmentCreatePayload(
            double startTime,
            double endTime,
            string? text,
            global::System.Collections.Generic.Dictionary<string, string>? translations)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Text = text;
            this.Translations = translations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentCreatePayload" /> class.
        /// </summary>
        public SegmentCreatePayload()
        {
        }
    }
}