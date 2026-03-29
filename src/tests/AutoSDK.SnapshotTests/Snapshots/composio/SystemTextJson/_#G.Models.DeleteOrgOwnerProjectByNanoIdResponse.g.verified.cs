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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteOrgOwnerProjectByNanoIdResponseStatusJsonConverter))]
        public global::G.DeleteOrgOwnerProjectByNanoIdResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrgOwnerProjectByNanoIdResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status indicating successful deletion<br/>
        /// Example: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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