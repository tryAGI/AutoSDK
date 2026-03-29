//HintName: G.Models.ResponsesPostResponsesContentApplicationJsonSchemaOutputItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesPostResponsesContentApplicationJsonSchemaOutputItems
    {
        /// <summary>
        /// The type of output object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ID of the output object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the output object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The role of the output object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The content for the output object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent? Content { get; set; }

        /// <summary>
        /// The name of the tool used in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The call_id for the tool call used in the output,
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The arguments used for the tool call used in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The label of the MCP server used in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// The output of the MCP tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// The error message from the MCP tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostResponsesContentApplicationJsonSchemaOutputItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of output object.
        /// </param>
        /// <param name="id">
        /// The ID of the output object.
        /// </param>
        /// <param name="status">
        /// The status of the output object.
        /// </param>
        /// <param name="role">
        /// The role of the output object.
        /// </param>
        /// <param name="content">
        /// The content for the output object.
        /// </param>
        /// <param name="name">
        /// The name of the tool used in the output.
        /// </param>
        /// <param name="callId">
        /// The call_id for the tool call used in the output,
        /// </param>
        /// <param name="arguments">
        /// The arguments used for the tool call used in the output.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server used in the output.
        /// </param>
        /// <param name="output">
        /// The output of the MCP tool call.
        /// </param>
        /// <param name="error">
        /// The error message from the MCP tool call.
        /// </param>
        public ResponsesPostResponsesContentApplicationJsonSchemaOutputItems(
            string? type,
            string? id,
            string? status,
            string? role,
            global::G.ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent? content,
            string? name,
            string? callId,
            string? arguments,
            string? serverLabel,
            string? output,
            string? error)
        {
            this.Type = type;
            this.Id = id;
            this.Status = status;
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.CallId = callId;
            this.Arguments = arguments;
            this.ServerLabel = serverLabel;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostResponsesContentApplicationJsonSchemaOutputItems" /> class.
        /// </summary>
        public ResponsesPostResponsesContentApplicationJsonSchemaOutputItems()
        {
        }
    }
}