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
        [global::Newtonsoft.Json.JsonProperty("sourceRequest")]
        public string? SourceRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cells", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateExperimentTableRowWithCellsBatchRequestRowCell> Cells { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputRecordId", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputRecordId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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