//HintName: G.Models.CreateEvaluationPipelineResponseReportColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvaluationPipelineResponseReportColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report_id")]
        public int? ReportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_type")]
        public string? ColumnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_part_of_score")]
        public bool? IsPartOfScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponseReportColumn" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reportId"></param>
        /// <param name="columnType"></param>
        /// <param name="name"></param>
        /// <param name="position"></param>
        /// <param name="isPartOfScore"></param>
        /// <param name="configuration"></param>
        public CreateEvaluationPipelineResponseReportColumn(
            int? id,
            int? reportId,
            string? columnType,
            string? name,
            int? position,
            bool? isPartOfScore,
            object? configuration)
        {
            this.Id = id;
            this.ReportId = reportId;
            this.ColumnType = columnType;
            this.Name = name;
            this.Position = position;
            this.IsPartOfScore = isPartOfScore;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponseReportColumn" /> class.
        /// </summary>
        public CreateEvaluationPipelineResponseReportColumn()
        {
        }
    }
}