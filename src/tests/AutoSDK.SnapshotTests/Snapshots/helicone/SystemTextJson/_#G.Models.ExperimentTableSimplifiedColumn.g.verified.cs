//HintName: G.Models.ExperimentTableSimplifiedColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentTableSimplifiedColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableSimplifiedColumn" /> class.
        /// </summary>
        /// <param name="columnType"></param>
        /// <param name="columnName"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentTableSimplifiedColumn(
            string columnType,
            string columnName,
            string id)
        {
            this.ColumnType = columnType ?? throw new global::System.ArgumentNullException(nameof(columnType));
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableSimplifiedColumn" /> class.
        /// </summary>
        public ExperimentTableSimplifiedColumn()
        {
        }
    }
}