//HintName: G.Models.ReturnBuiltinTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnBuiltinTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_type")]
        public string? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_content")]
        public string? FallbackContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnBuiltinTool" /> class.
        /// </summary>
        /// <param name="toolType"></param>
        /// <param name="name"></param>
        /// <param name="fallbackContent"></param>
        public ReturnBuiltinTool(
            string? toolType,
            string? name,
            string? fallbackContent)
        {
            this.ToolType = toolType;
            this.Name = name;
            this.FallbackContent = fallbackContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnBuiltinTool" /> class.
        /// </summary>
        public ReturnBuiltinTool()
        {
        }
    }
}