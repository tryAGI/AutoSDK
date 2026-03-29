//HintName: G.Models.CreateExperimentTableRowWithCellsBatchRequestRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentTableRowWithCellsBatchRequestRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceRequest")]
        public string? SourceRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateExperimentTableRowWithCellsBatchRequestRowCell> Cells { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputRecordId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputRecordId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowWithCellsBatchRequestRow" /> class.
        /// </summary>
        /// <param name="cells"></param>
        /// <param name="datasetId"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="inputRecordId"></param>
        /// <param name="sourceRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentTableRowWithCellsBatchRequestRow(
            global::System.Collections.Generic.IList<global::G.CreateExperimentTableRowWithCellsBatchRequestRowCell> cells,
            string datasetId,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string inputRecordId,
            string? sourceRequest)
        {
            this.SourceRequest = sourceRequest;
            this.Cells = cells ?? throw new global::System.ArgumentNullException(nameof(cells));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.InputRecordId = inputRecordId ?? throw new global::System.ArgumentNullException(nameof(inputRecordId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowWithCellsBatchRequestRow" /> class.
        /// </summary>
        public CreateExperimentTableRowWithCellsBatchRequestRow()
        {
        }
    }
}