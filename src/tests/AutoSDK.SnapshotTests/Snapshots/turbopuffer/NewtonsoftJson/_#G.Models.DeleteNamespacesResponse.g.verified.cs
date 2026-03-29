//HintName: G.Models.DeleteNamespacesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a successful namespace deletion request.
    /// </summary>
    public sealed partial class DeleteNamespacesResponse
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <default>"OK"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "OK";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteNamespacesResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the request.
        /// </param>
        public DeleteNamespacesResponse(
            string status = "OK")
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteNamespacesResponse" /> class.
        /// </summary>
        public DeleteNamespacesResponse()
        {
        }
    }
}