//HintName: G.Models.PurgeLemurRequestDataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"request_id":"914fe7e4-f10a-4364-8946-34614c2873f6","request_id_to_purge":"b7eb03ec-1650-4181-949b-75d9de317de1","deleted":true}
    /// </summary>
    public sealed partial class PurgeLemurRequestDataResponse
    {
        /// <summary>
        /// The ID of the deletion request of the LeMUR request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestId { get; set; } = default!;

        /// <summary>
        /// The ID of the LeMUR request to purge the data for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id_to_purge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestIdToPurge { get; set; } = default!;

        /// <summary>
        /// Whether the request data was deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PurgeLemurRequestDataResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The ID of the deletion request of the LeMUR request
        /// </param>
        /// <param name="requestIdToPurge">
        /// The ID of the LeMUR request to purge the data for
        /// </param>
        /// <param name="deleted">
        /// Whether the request data was deleted
        /// </param>
        public PurgeLemurRequestDataResponse(
            global::System.Guid requestId,
            global::System.Guid requestIdToPurge,
            bool deleted)
        {
            this.RequestId = requestId;
            this.RequestIdToPurge = requestIdToPurge;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurgeLemurRequestDataResponse" /> class.
        /// </summary>
        public PurgeLemurRequestDataResponse()
        {
        }
    }
}