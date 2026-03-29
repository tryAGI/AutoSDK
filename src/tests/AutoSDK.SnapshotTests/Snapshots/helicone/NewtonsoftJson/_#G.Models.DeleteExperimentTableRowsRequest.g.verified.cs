//HintName: G.Models.DeleteExperimentTableRowsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteExperimentTableRowsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputRecordIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> InputRecordIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteExperimentTableRowsRequest" /> class.
        /// </summary>
        /// <param name="inputRecordIds"></param>
        public DeleteExperimentTableRowsRequest(
            global::System.Collections.Generic.IList<string> inputRecordIds)
        {
            this.InputRecordIds = inputRecordIds ?? throw new global::System.ArgumentNullException(nameof(inputRecordIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteExperimentTableRowsRequest" /> class.
        /// </summary>
        public DeleteExperimentTableRowsRequest()
        {
        }
    }
}