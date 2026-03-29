//HintName: G.Models.PostToolRouterSessionRequestToolsVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestToolsVariant3
    {
        /// <summary>
        /// MCP tags to filter tools. Array format is treated as enabled list. Object format supports both enabled and disabled lists.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </summary>
        /// <example>{"enable":["openWorldHint"],"disable":["destructiveHint"]}</example>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestToolsVariant3Tag>, global::G.PostToolRouterSessionRequestToolsVariant3Tags> Tags { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant3" /> class.
        /// </summary>
        /// <param name="tags">
        /// MCP tags to filter tools. Array format is treated as enabled list. Object format supports both enabled and disabled lists.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </param>
        public PostToolRouterSessionRequestToolsVariant3(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestToolsVariant3Tag>, global::G.PostToolRouterSessionRequestToolsVariant3Tags> tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant3" /> class.
        /// </summary>
        public PostToolRouterSessionRequestToolsVariant3()
        {
        }
    }
}