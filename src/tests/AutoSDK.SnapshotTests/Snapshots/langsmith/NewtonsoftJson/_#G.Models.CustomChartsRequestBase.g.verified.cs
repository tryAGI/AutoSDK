//HintName: G.Models.CustomChartsRequestBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsRequestBase
    {
        /// <summary>
        /// Default Value: UTC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

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
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("omit_data")]
        public bool? OmitData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsRequestBase" /> class.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="omitData">
        /// Default Value: false
        /// </param>
        public CustomChartsRequestBase(
            string? timezone,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::G.TimedeltaInput? stride,
            bool? omitData)
        {
            this.Timezone = timezone;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Stride = stride;
            this.OmitData = omitData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsRequestBase" /> class.
        /// </summary>
        public CustomChartsRequestBase()
        {
        }
    }
}