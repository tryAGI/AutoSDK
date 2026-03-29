//HintName: G.Models.ExperimentTableColumnCell.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentTableColumnCell
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rowIndex", Required = global::Newtonsoft.Json.Required.Always)]
        public double RowIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableColumnCell" /> class.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="id"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="value"></param>
        /// <param name="requestId"></param>
        public ExperimentTableColumnCell(
            double rowIndex,
            string id,
            global::G.RecordStringAny? metadata,
            string? value,
            string? requestId)
        {
            this.Metadata = metadata;
            this.Value = value;
            this.RequestId = requestId;
            this.RowIndex = rowIndex;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableColumnCell" /> class.
        /// </summary>
        public ExperimentTableColumnCell()
        {
        }
    }
}