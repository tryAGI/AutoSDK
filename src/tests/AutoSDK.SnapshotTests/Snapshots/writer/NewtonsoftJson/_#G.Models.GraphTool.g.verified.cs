//HintName: G.Models.GraphTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphTool
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GraphToolType Type { get; set; }

        /// <summary>
        /// A tool that uses Knowledge Graphs as context for responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GraphFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphTool" /> class.
        /// </summary>
        /// <param name="function">
        /// A tool that uses Knowledge Graphs as context for responses.
        /// </param>
        /// <param name="type">
        /// The type of tool.
        /// </param>
        public GraphTool(
            global::G.GraphFunction function,
            global::G.GraphToolType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphTool" /> class.
        /// </summary>
        public GraphTool()
        {
        }
    }
}