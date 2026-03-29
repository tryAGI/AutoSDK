//HintName: G.Models.CodexLocalShellTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Local shell tool configuration
    /// </summary>
    public sealed partial class CodexLocalShellTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodexLocalShellToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodexLocalShellTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CodexLocalShellTool(
            global::G.CodexLocalShellToolType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodexLocalShellTool" /> class.
        /// </summary>
        public CodexLocalShellTool()
        {
        }
    }
}