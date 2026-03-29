//HintName: G.Models.HeliconeEventTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeEventTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_type")]
        public global::G.HeliconeEventToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeEventTool" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="input"></param>
        /// <param name="type"></param>
        public HeliconeEventTool(
            string toolName,
            object input,
            global::G.HeliconeEventToolType type)
        {
            this.Type = type;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeEventTool" /> class.
        /// </summary>
        public HeliconeEventTool()
        {
        }
    }
}