//HintName: G.Models.DeleteMcpByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response indicating the success of the delete operation
    /// </summary>
    public sealed partial class DeleteMcpByIdResponse
    {
        /// <summary>
        /// Unique identifier of the MCP server to retrieve, update, or delete<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Indicates whether the MCP server was successfully deleted<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMcpByIdResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the MCP server to retrieve, update, or delete<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the MCP server was successfully deleted<br/>
        /// Example: true
        /// </param>
        public DeleteMcpByIdResponse(
            string id,
            bool deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMcpByIdResponse" /> class.
        /// </summary>
        public DeleteMcpByIdResponse()
        {
        }
    }
}