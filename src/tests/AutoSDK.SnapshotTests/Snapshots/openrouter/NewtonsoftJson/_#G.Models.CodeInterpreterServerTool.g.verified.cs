//HintName: G.Models.CodeInterpreterServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code interpreter tool configuration
    /// </summary>
    public sealed partial class CodeInterpreterServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeInterpreterServerToolContainer Container { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerTool" /> class.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="type"></param>
        public CodeInterpreterServerTool(
            global::G.CodeInterpreterServerToolContainer container,
            global::G.CodeInterpreterServerToolType type)
        {
            this.Type = type;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerTool" /> class.
        /// </summary>
        public CodeInterpreterServerTool()
        {
        }
    }
}