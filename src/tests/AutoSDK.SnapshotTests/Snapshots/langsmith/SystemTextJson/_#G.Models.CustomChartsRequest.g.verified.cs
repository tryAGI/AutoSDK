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
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stride")]
        public global::G.TimedeltaInput? Stride { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("omit_data")]
        public bool? OmitData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_index")]
        public int? AfterIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value_id")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TagValueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="omitData">
        /// Default Value: false
        /// </param>
        /// <param name="afterIndex"></param>
        /// <param name="tagValueId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsRequest(
            string? timezone,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::G.TimedeltaInput? stride,
            bool? omitData,
            int? afterIndex,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId)
        {
            this.Timezone = timezone;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Stride = stride;
            this.OmitData = omitData;
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