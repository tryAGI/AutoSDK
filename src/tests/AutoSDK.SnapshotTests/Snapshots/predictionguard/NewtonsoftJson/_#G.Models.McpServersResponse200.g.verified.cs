//HintName: G.Models.McpServersResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersResponse200
    {
        /// <summary>
        /// Type of object (list).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The available MCP servers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.McpServersGetResponsesContentApplicationJsonSchemaDataItems>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersResponse200" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of object (list).
        /// </param>
        /// <param name="data">
        /// The available MCP servers.
        /// </param>
        public McpServersResponse200(
            string? @object,
            global::System.Collections.Generic.IList<global::G.McpServersGetResponsesContentApplicationJsonSchemaDataItems>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersResponse200" /> class.
        /// </summary>
        public McpServersResponse200()
        {
        }
    }
}