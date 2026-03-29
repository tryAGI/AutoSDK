//HintName: G.Models.WebSearchServerToolOpenRouter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenRouter built-in server tool: searches the web for current information
    /// </summary>
    public sealed partial class WebSearchServerToolOpenRouter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WebSearchServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.WebSearchServerToolOpenRouterParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public WebSearchServerToolOpenRouter(
            global::G.WebSearchServerToolOpenRouterType type,
            global::G.WebSearchServerToolOpenRouterParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolOpenRouter" /> class.
        /// </summary>
        public WebSearchServerToolOpenRouter()
        {
        }
    }
}