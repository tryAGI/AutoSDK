//HintName: G.Models.WebSearchToolResultContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results from a web search tool invocation.
    /// </summary>
    public sealed partial class WebSearchToolResultContent
    {
        /// <summary>
        /// Default Value: web_search_tool_result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebSearchToolResultContentTypeJsonConverter))]
        public global::G.WebSearchToolResultContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.WebSearchResult>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolResultContent" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: web_search_tool_result
        /// </param>
        /// <param name="content">
        /// Default Value: []
        /// </param>
        public WebSearchToolResultContent(
            string toolUseId,
            global::G.WebSearchToolResultContentType? type,
            global::System.Collections.Generic.IList<global::G.WebSearchResult>? content)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolResultContent" /> class.
        /// </summary>
        public WebSearchToolResultContent()
        {
        }
    }
}