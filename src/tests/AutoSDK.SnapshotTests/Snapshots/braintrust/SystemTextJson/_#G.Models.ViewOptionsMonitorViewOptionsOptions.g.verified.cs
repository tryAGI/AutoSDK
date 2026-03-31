//HintName: G.Models.ViewOptionsMonitorViewOptionsOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOptionsMonitorViewOptionsOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeJsonConverter))]
        public global::G.ViewOptionsMonitorViewOptionsOptionsSpanType? SpanType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rangeValue")]
        public string? RangeValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameStart")]
        public string? FrameStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameEnd")]
        public string? FrameEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tzUTC")]
        public bool? TzUTC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartVisibility")]
        public global::System.Collections.Generic.Dictionary<string, bool>? ChartVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeJsonConverter))]
        public global::G.ViewOptionsMonitorViewOptionsOptionsType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsMonitorViewOptionsOptions" /> class.
        /// </summary>
        /// <param name="spanType"></param>
        /// <param name="rangeValue"></param>
        /// <param name="frameStart"></param>
        /// <param name="frameEnd"></param>
        /// <param name="tzUTC"></param>
        /// <param name="chartVisibility"></param>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="groupBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewOptionsMonitorViewOptionsOptions(
            global::G.ViewOptionsMonitorViewOptionsOptionsSpanType? spanType,
            string? rangeValue,
            string? frameStart,
            string? frameEnd,
            bool? tzUTC,
            global::System.Collections.Generic.Dictionary<string, bool>? chartVisibility,
            string? projectId,
            global::G.ViewOptionsMonitorViewOptionsOptionsType? type,
            string? groupBy)
        {
            this.SpanType = spanType;
            this.RangeValue = rangeValue;
            this.FrameStart = frameStart;
            this.FrameEnd = frameEnd;
            this.TzUTC = tzUTC;
            this.ChartVisibility = chartVisibility;
            this.ProjectId = projectId;
            this.Type = type;
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsMonitorViewOptionsOptions" /> class.
        /// </summary>
        public ViewOptionsMonitorViewOptionsOptions()
        {
        }
    }
}