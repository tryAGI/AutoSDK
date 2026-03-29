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
        [global::Newtonsoft.Json.JsonProperty("spanType")]
        public global::G.ViewOptionsMonitorViewOptionsOptionsSpanType? SpanType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rangeValue")]
        public string? RangeValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frameStart")]
        public string? FrameStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frameEnd")]
        public string? FrameEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tzUTC")]
        public bool? TzUTC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chartVisibility")]
        public global::System.Collections.Generic.Dictionary<string, bool>? ChartVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ViewOptionsMonitorViewOptionsOptionsType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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