//HintName: G.Models.BetaToolChoiceAny.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model will use any available tools.
    /// </summary>
    public sealed partial class BetaToolChoiceAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaToolChoiceAnyType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaToolChoiceAny" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="disableParallelToolUse">
        /// Whether to disable parallel tool use.<br/>
        /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
        /// </param>
        public BetaToolChoiceAny(
            global::G.BetaToolChoiceAnyType type,
            bool? disableParallelToolUse)
        {
            this.Type = type;
            this.DisableParallelToolUse = disableParallelToolUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChoiceAny" /> class.
        /// </summary>
        public BetaToolChoiceAny()
        {
        }
    }
}