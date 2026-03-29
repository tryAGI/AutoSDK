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
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowWithCellsBatchRequestRowCell" /> class.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="metadata"></param>
        /// <param name="value"></param>
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