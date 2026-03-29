//HintName: G.Models.CreateExperimentTableRowWithCellsBatchRequestRowCell.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentTableRowWithCellsBatchRequestRowCell
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowWithCellsBatchRequestRowCell" /> class.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="metadata"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentTableRowWithCellsBatchRequestRowCell(
            string columnId,
            object? metadata,
            string? value)
        {
            this.Metadata = metadata;
            this.Value = value;
            this.ColumnId = columnId ?? throw new global::System.ArgumentNullException(nameof(columnId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowWithCellsBatchRequestRowCell" /> class.
        /// </summary>
        public CreateExperimentTableRowWithCellsBatchRequestRowCell()
        {
        }
    }
}