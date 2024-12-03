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
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// The ID of the LeMUR request to purge the data for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id_to_purge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestIdToPurge { get; set; }

        /// <summary>
        /// Whether the request data was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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