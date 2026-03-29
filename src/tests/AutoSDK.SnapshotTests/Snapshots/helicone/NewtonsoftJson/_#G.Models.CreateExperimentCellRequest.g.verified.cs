//HintName: G.Models.CreateExperimentCellRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentCellRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rowIndex", Required = global::Newtonsoft.Json.Required.Always)]
        public double RowIndex { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateExperimentCellRequest" /> class.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnId"></param>
        /// <param name="value"></param>
        public CreateExperimentCellRequest(
            double rowIndex,
            string columnId,
            string? value)
        {
            this.Value = value;
            this.RowIndex = rowIndex;
            this.ColumnId = columnId ?? throw new global::System.ArgumentNullException(nameof(columnId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentCellRequest" /> class.
        /// </summary>
        public CreateExperimentCellRequest()
        {
        }
    }
}