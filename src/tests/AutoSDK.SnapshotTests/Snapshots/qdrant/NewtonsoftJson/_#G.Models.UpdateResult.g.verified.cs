//HintName: G.Models.UpdateResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResult
    {
        /// <summary>
        /// Sequential number of the operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operation_id")]
        public int? OperationId { get; set; }

        /// <summary>
        /// `Acknowledged` - Request is saved to WAL and will be process in a queue. `Completed` - Request is completed, changes are actual. `WaitTimeout` - Request is waiting for timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult" /> class.
        /// </summary>
        /// <param name="status">
        /// `Acknowledged` - Request is saved to WAL and will be process in a queue. `Completed` - Request is completed, changes are actual. `WaitTimeout` - Request is waiting for timeout.
        /// </param>
        /// <param name="operationId">
        /// Sequential number of the operation
        /// </param>
        public UpdateResult(
            global::G.UpdateStatus status,
            int? operationId)
        {
            this.OperationId = operationId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult" /> class.
        /// </summary>
        public UpdateResult()
        {
        }
    }
}