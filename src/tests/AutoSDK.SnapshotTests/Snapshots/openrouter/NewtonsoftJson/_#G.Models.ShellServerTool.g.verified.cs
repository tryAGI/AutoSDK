//HintName: G.Models.ShellServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Shell tool configuration
    /// </summary>
    public sealed partial class ShellServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ShellServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ShellServerTool(
            global::G.ShellServerToolType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerTool" /> class.
        /// </summary>
        public ShellServerTool()
        {
        }
    }
}