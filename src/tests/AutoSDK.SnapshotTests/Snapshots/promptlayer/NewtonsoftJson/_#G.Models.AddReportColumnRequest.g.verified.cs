//HintName: G.Models.AddReportColumnRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"report_id":456,"column_type":"PROMPT_TEMPLATE","name":"Generate Answer","configuration":{"template":{"name":"qa_template","version_number":null},"prompt_template_variable_mappings":{"question":"input_question"},"engine":{"provider":"openai","model":"gpt-4","parameters":{"temperature":0.7}}}}
    /// </summary>
    public sealed partial class AddReportColumnRequest
    {
        /// <summary>
        /// The ID of the evaluation pipeline to add this column to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReportId { get; set; } = default!;

        /// <summary>
        /// The type of evaluation or transformation this column performs. Must be one of the supported column types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AddReportColumnRequestColumnType ColumnType { get; set; } = default!;

        /// <summary>
        /// Display name for this column. Must be unique within the pipeline. This name is used to reference the column in subsequent steps.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Column-specific configuration. The schema varies based on column_type. See documentation for each type's requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public object Configuration { get; set; } = default!;

        /// <summary>
        /// Optional position for the column. If not specified, the column is added at the end. Cannot overwrite dataset columns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReportColumnRequest" /> class.
        /// </summary>
        /// <param name="reportId">
        /// The ID of the evaluation pipeline to add this column to.
        /// </param>
        /// <param name="columnType">
        /// The type of evaluation or transformation this column performs. Must be one of the supported column types.
        /// </param>
        /// <param name="name">
        /// Display name for this column. Must be unique within the pipeline. This name is used to reference the column in subsequent steps.
        /// </param>
        /// <param name="configuration">
        /// Column-specific configuration. The schema varies based on column_type. See documentation for each type's requirements.
        /// </param>
        /// <param name="position">
        /// Optional position for the column. If not specified, the column is added at the end. Cannot overwrite dataset columns.
        /// </param>
        public AddReportColumnRequest(
            int reportId,
            global::G.AddReportColumnRequestColumnType columnType,
            string name,
            object configuration,
            int? position)
        {
            this.ReportId = reportId;
            this.ColumnType = columnType;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReportColumnRequest" /> class.
        /// </summary>
        public AddReportColumnRequest()
        {
        }
    }
}