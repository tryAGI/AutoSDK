//HintName: G.Models.State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class State
    {
        /// <summary>
        /// Name of the state, must be unique for each state. Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).<br/>
        /// Example: information_collection
        /// </summary>
        /// <example>information_collection</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Prompt of the state, will be appended to the system prompt of LLM.<br/>
        /// - System prompt = general prompt + state prompt.<br/>
        /// Example: ## Task<br/>
        /// You will follow the steps below...
        /// </summary>
        /// <example>
        /// ## Task<br/>
        /// You will follow the steps below...
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("state_prompt")]
        public string? StatePrompt { get; set; }

        /// <summary>
        /// Edges of the state define how and what state can be reached from this state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.IList<global::G.StateEdge>? Edges { get; set; }

        /// <summary>
        /// A list of tools specific to this state the model may call (to get external knowledge, call API, etc). You can select from some common predefined tools like end call, transfer call, etc; or you can create your own custom tool for the LLM to use.<br/>
        /// - Tools of LLM = general tools + state tools + state transitions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="State" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the state, must be unique for each state. Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).<br/>
        /// Example: information_collection
        /// </param>
        /// <param name="statePrompt">
        /// Prompt of the state, will be appended to the system prompt of LLM.<br/>
        /// - System prompt = general prompt + state prompt.<br/>
        /// Example: ## Task<br/>
        /// You will follow the steps below...
        /// </param>
        /// <param name="edges">
        /// Edges of the state define how and what state can be reached from this state.
        /// </param>
        /// <param name="tools">
        /// A list of tools specific to this state the model may call (to get external knowledge, call API, etc). You can select from some common predefined tools like end call, transfer call, etc; or you can create your own custom tool for the LLM to use.<br/>
        /// - Tools of LLM = general tools + state tools + state transitions
        /// </param>
        public State(
            string name,
            string? statePrompt,
            global::System.Collections.Generic.IList<global::G.StateEdge>? edges,
            global::System.Collections.Generic.IList<global::G.Tool>? tools)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.StatePrompt = statePrompt;
            this.Edges = edges;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="State" /> class.
        /// </summary>
        public State()
        {
        }
    }
}