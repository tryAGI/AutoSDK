//HintName: G.Models.KPIDetailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response serializer for KPI detail endpoint.<br/>
    /// Structure varies based on segmentation parameters.
    /// </summary>
    public sealed partial class KPIDetailResponse
    {
        /// <summary>
        /// Project-segmented data (compact format with parallel arrays)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("by_project")]
        public global::G.KPIProjectSegment? ByProject { get; set; }

        /// <summary>
        /// User-segmented data (compact format with parallel arrays)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("by_user")]
        public global::G.KPIUserSegment? ByUser { get; set; }

        /// <summary>
        /// KPI identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kpi_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string KpiKey { get; set; } = default!;

        /// <summary>
        /// Human-readable KPI label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kpi_label")]
        public string? KpiLabel { get; set; }

        /// <summary>
        /// 2D matrix (time × user) in compact format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("matrix")]
        public global::G.KPIMatrixSegment? Matrix { get; set; }

        /// <summary>
        /// 2D matrix (time × project) in compact format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_matrix")]
        public global::G.KPIProjectMatrixSegment? ProjectMatrix { get; set; }

        /// <summary>
        /// Type of segmentation applied<br/>
        /// * `none` - none<br/>
        /// * `time` - time<br/>
        /// * `user` - user<br/>
        /// * `project` - project<br/>
        /// * `matrix` - matrix<br/>
        /// * `project_matrix` - project_matrix
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentation", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SegmentationEnumJsonConverter))]
        public global::G.SegmentationEnum Segmentation { get; set; } = default!;

        /// <summary>
        /// Time-segmented data (compact format with parallel arrays)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_series")]
        public global::G.KPITimeSegment? TimeSeries { get; set; }

        /// <summary>
        /// Total value (no segmentation)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public global::G.KPIValue? Total { get; set; }

        /// <summary>
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Unit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIDetailResponse" /> class.
        /// </summary>
        /// <param name="kpiKey">
        /// KPI identifier
        /// </param>
        /// <param name="segmentation">
        /// Type of segmentation applied<br/>
        /// * `none` - none<br/>
        /// * `time` - time<br/>
        /// * `user` - user<br/>
        /// * `project` - project<br/>
        /// * `matrix` - matrix<br/>
        /// * `project_matrix` - project_matrix
        /// </param>
        /// <param name="unit">
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </param>
        /// <param name="byProject">
        /// Project-segmented data (compact format with parallel arrays)
        /// </param>
        /// <param name="byUser">
        /// User-segmented data (compact format with parallel arrays)
        /// </param>
        /// <param name="kpiLabel">
        /// Human-readable KPI label
        /// </param>
        /// <param name="matrix">
        /// 2D matrix (time × user) in compact format
        /// </param>
        /// <param name="projectMatrix">
        /// 2D matrix (time × project) in compact format
        /// </param>
        /// <param name="timeSeries">
        /// Time-segmented data (compact format with parallel arrays)
        /// </param>
        /// <param name="total">
        /// Total value (no segmentation)
        /// </param>
        public KPIDetailResponse(
            string kpiKey,
            global::G.SegmentationEnum segmentation,
            string unit,
            global::G.KPIProjectSegment? byProject,
            global::G.KPIUserSegment? byUser,
            string? kpiLabel,
            global::G.KPIMatrixSegment? matrix,
            global::G.KPIProjectMatrixSegment? projectMatrix,
            global::G.KPITimeSegment? timeSeries,
            global::G.KPIValue? total)
        {
            this.ByProject = byProject;
            this.ByUser = byUser;
            this.KpiKey = kpiKey ?? throw new global::System.ArgumentNullException(nameof(kpiKey));
            this.KpiLabel = kpiLabel;
            this.Matrix = matrix;
            this.ProjectMatrix = projectMatrix;
            this.Segmentation = segmentation;
            this.TimeSeries = timeSeries;
            this.Total = total;
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIDetailResponse" /> class.
        /// </summary>
        public KPIDetailResponse()
        {
        }
    }
}