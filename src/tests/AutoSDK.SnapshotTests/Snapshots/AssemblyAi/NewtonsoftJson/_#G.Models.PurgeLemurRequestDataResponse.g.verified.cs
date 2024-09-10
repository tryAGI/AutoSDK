//HintName: G.Models.PurgeLemurRequestDataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
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
    }
}