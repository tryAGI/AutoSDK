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
        [global::System.Text.Json.Serialization.JsonPropertyName("column_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnType { get; set; }

        /// <summary>
        /// Display name for the column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Column-type-specific configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// Position in the pipeline (auto-assigned if not provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Whether this column contributes to built-in score averaging (defaults to false)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_part_of_score")]
        public bool? IsPartOfScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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