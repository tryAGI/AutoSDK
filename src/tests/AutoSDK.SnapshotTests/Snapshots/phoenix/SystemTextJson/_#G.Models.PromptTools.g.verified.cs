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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tools";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ToolsItem> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolChoiceJsonConverter))]
        public global::G.ToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_parallel_tool_calls")]
        public bool? DisableParallelToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTools" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="disableParallelToolCalls"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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