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
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsRequestBase(
            global::System.DateTime startTime,
            string? timezone,
            global::System.DateTime? endTime,
            global::G.TimedeltaInput? stride)
        {
            this.StartTime = startTime;
            this.Timezone = timezone;
            this.EndTime = endTime;
            this.Stride = stride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsRequestBase" /> class.
        /// </summary>
        public CustomChartsRequestBase()
        {
        }
    }
}