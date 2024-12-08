//HintName: G.Models.BetaToolChoiceTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model will use the specified tool with `tool_choice.name`.
    /// </summary>
    public sealed partial class BetaToolChoiceTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaToolChoiceToolType Type { get; set; }

        /// <summary>
        /// The name of the tool to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_parallel_tool_use")]
        public bool? DisableParallelToolUse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChoiceTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the tool to use.
        /// </param>
        /// <param name="disableParallelToolUse">
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
        /// </param>
        public BetaToolChoiceTool(
            string name,
            global::G.BetaToolChoiceToolType type,
            bool? disableParallelToolUse)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.DisableParallelToolUse = disableParallelToolUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChoiceTool" /> class.
        /// </summary>
        public BetaToolChoiceTool()
        {
        }
    }
}