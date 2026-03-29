//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems
    {
        /// <summary>
        /// The type of tool to call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the tool to be called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The parameters the tool accepts, described as a JSON Schema object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItemsParameters? Parameters { get; set; }

        /// <summary>
        /// Whether to enable strict schema adherence when generating the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// A description of what the tool does.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The label for the MCP server being used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// The URL for the MCP server being used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// The description of the MCP server being used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_description")]
        public string? ServerDescription { get; set; }

        /// <summary>
        /// The initials of the MCP server being used. Used for the ID of the output object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initials")]
        public string? Initials { get; set; }

        /// <summary>
        /// The authorization needed for the MCP server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// The necessary headers needed for calling the MCP server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItemsHeaders? Headers { get; set; }

        /// <summary>
        /// An array of the tools in the MCP server that the model is allowed to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools")]
        public global::System.Collections.Generic.IList<object>? AllowedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool to call.
        /// </param>
        /// <param name="name">
        /// The name of the tool to be called.
        /// </param>
        /// <param name="parameters">
        /// The parameters the tool accepts, described as a JSON Schema object.
        /// </param>
        /// <param name="strict">
        /// Whether to enable strict schema adherence when generating the tool call.
        /// </param>
        /// <param name="description">
        /// A description of what the tool does.
        /// </param>
        /// <param name="serverLabel">
        /// The label for the MCP server being used.
        /// </param>
        /// <param name="serverUrl">
        /// The URL for the MCP server being used.
        /// </param>
        /// <param name="serverDescription">
        /// The description of the MCP server being used.
        /// </param>
        /// <param name="initials">
        /// The initials of the MCP server being used. Used for the ID of the output object.
        /// </param>
        /// <param name="authorization">
        /// The authorization needed for the MCP server.
        /// </param>
        /// <param name="headers">
        /// The necessary headers needed for calling the MCP server.
        /// </param>
        /// <param name="allowedTools">
        /// An array of the tools in the MCP server that the model is allowed to use.
        /// </param>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems(
            string? type,
            string? name,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItemsParameters? parameters,
            bool? strict,
            string? description,
            string? serverLabel,
            string? serverUrl,
            string? serverDescription,
            string? initials,
            string? authorization,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItemsHeaders? headers,
            global::System.Collections.Generic.IList<object>? allowedTools)
        {
            this.Type = type;
            this.Name = name;
            this.Parameters = parameters;
            this.Strict = strict;
            this.Description = description;
            this.ServerLabel = serverLabel;
            this.ServerUrl = serverUrl;
            this.ServerDescription = serverDescription;
            this.Initials = initials;
            this.Authorization = authorization;
            this.Headers = headers;
            this.AllowedTools = allowedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems" /> class.
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems()
        {
        }
    }
}