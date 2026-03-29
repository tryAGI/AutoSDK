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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "OK";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteNamespacesResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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