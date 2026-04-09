//HintName: G.Models.GetEvaluationRowsResponseRowItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEvaluationRowsResponseRowItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetEvaluationRowsResponseRowItemTypeJsonConverter))]
        public global::G.GetEvaluationRowsResponseRowItemType Type { get; set; } = default!;

        /// <summary>
        /// The cell value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Evaluation status (only for eval cells)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetEvaluationRowsResponseRowItemStatusJsonConverter))]
        public global::G.GetEvaluationRowsResponseRowItemStatus? Status { get; set; }

        /// <summary>
        /// Error details (only present for failed eval cells)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvaluationRowsResponseRowItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value">
        /// The cell value
        /// </param>
        /// <param name="status">
        /// Evaluation status (only for eval cells)
        /// </param>
        /// <param name="errorMessage">
        /// Error details (only present for failed eval cells)
        /// </param>
        public GetEvaluationRowsResponseRowItem(
            global::G.GetEvaluationRowsResponseRowItemType type,
            object? value,
            global::G.GetEvaluationRowsResponseRowItemStatus? status,
            string? errorMessage)
        {
            this.Type = type;
            this.Value = value;
            this.Status = status;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvaluationRowsResponseRowItem" /> class.
        /// </summary>
        public GetEvaluationRowsResponseRowItem()
        {
        }
    }
}