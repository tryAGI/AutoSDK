//HintName: G.Models.PromptTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptTools
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tools"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "tools";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolsItem> Tools { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.ToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_parallel_tool_calls")]
        public bool? DisableParallelToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTools" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="disableParallelToolCalls"></param>
        /// <param name="type"></param>
        public PromptTools(
            global::System.Collections.Generic.IList<global::G.ToolsItem> tools,
            global::G.ToolChoice? toolChoice,
            bool? disableParallelToolCalls,
            string type = "tools")
        {
            this.Type = type;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.ToolChoice = toolChoice;
            this.DisableParallelToolCalls = disableParallelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTools" /> class.
        /// </summary>
        public PromptTools()
        {
        }
    }
}