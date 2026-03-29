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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        public int? ReportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_type")]
        public string? ColumnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_part_of_score")]
        public bool? IsPartOfScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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