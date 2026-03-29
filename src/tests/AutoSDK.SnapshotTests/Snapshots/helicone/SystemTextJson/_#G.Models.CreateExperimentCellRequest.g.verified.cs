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
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowIndex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RowIndex { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateExperimentCellRequest" /> class.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnId"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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