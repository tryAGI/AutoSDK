//HintName: G.Models.DeleteOrgOwnerProjectByNanoIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response indicating successful project deletion
    /// </summary>
    public sealed partial class DeleteOrgOwnerProjectByNanoIdResponse
    {
        /// <summary>
        /// Status indicating successful deletion<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DeleteOrgOwnerProjectByNanoIdResponseStatusJsonConverter))]
        public global::G.DeleteOrgOwnerProjectByNanoIdResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrgOwnerProjectByNanoIdResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status indicating successful deletion<br/>
        /// Example: success
        /// </param>
        public DeleteOrgOwnerProjectByNanoIdResponse(
            global::G.DeleteOrgOwnerProjectByNanoIdResponseStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrgOwnerProjectByNanoIdResponse" /> class.
        /// </summary>
        public DeleteOrgOwnerProjectByNanoIdResponse()
        {
        }
    }
}