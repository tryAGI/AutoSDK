//HintName: G.Models.CustomChartsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsRequest
    {
        /// <summary>
        /// Default Value: UTC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stride")]
        public global::G.TimedeltaInput? Stride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after_index")]
        public int? AfterIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_value_id")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TagValueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsRequest" /> class.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="afterIndex"></param>
        /// <param name="tagValueId"></param>
        public CustomChartsRequest(
            global::System.DateTime startTime,
            string? timezone,
            global::System.DateTime? endTime,
            global::G.TimedeltaInput? stride,
            int? afterIndex,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId)
        {
            this.StartTime = startTime;
            this.Timezone = timezone;
            this.EndTime = endTime;
            this.Stride = stride;
            this.AfterIndex = afterIndex;
            this.TagValueId = tagValueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsRequest" /> class.
        /// </summary>
        public CustomChartsRequest()
        {
        }
    }
}