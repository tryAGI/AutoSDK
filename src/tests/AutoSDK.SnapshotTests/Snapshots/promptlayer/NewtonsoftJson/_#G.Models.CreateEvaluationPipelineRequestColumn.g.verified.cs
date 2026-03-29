//HintName: G.Models.CreateEvaluationPipelineRequestColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvaluationPipelineRequestColumn
    {
        /// <summary>
        /// Type of column (e.g., LLM_ASSERTION, VARIABLE, CODE_EXECUTION, PROMPT_TEMPLATE)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnType { get; set; } = default!;

        /// <summary>
        /// Display name for the column
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Column-type-specific configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public object Configuration { get; set; } = default!;

        /// <summary>
        /// Position in the pipeline (auto-assigned if not provided)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Whether this column contributes to built-in score averaging (defaults to false)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_part_of_score")]
        public bool? IsPartOfScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequestColumn" /> class.
        /// </summary>
        /// <param name="columnType">
        /// Type of column (e.g., LLM_ASSERTION, VARIABLE, CODE_EXECUTION, PROMPT_TEMPLATE)
        /// </param>
        /// <param name="name">
        /// Display name for the column
        /// </param>
        /// <param name="configuration">
        /// Column-type-specific configuration
        /// </param>
        /// <param name="position">
        /// Position in the pipeline (auto-assigned if not provided)
        /// </param>
        /// <param name="isPartOfScore">
        /// Whether this column contributes to built-in score averaging (defaults to false)
        /// </param>
        public CreateEvaluationPipelineRequestColumn(
            string columnType,
            string name,
            object configuration,
            int? position,
            bool? isPartOfScore)
        {
            this.ColumnType = columnType ?? throw new global::System.ArgumentNullException(nameof(columnType));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Position = position;
            this.IsPartOfScore = isPartOfScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequestColumn" /> class.
        /// </summary>
        public CreateEvaluationPipelineRequestColumn()
        {
        }
    }
}