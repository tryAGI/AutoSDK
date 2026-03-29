//HintName: G.Models.CreateExperimentTableRowBatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentTableRowBatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateExperimentTableRowBatchRequestRow> Rows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowBatchRequest" /> class.
        /// </summary>
        /// <param name="rows"></param>
        public CreateExperimentTableRowBatchRequest(
            global::System.Collections.Generic.IList<global::G.CreateExperimentTableRowBatchRequestRow> rows)
        {
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowBatchRequest" /> class.
        /// </summary>
        public CreateExperimentTableRowBatchRequest()
        {
        }
    }
}