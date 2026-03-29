//HintName: G.Models.StateEdge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateEdge
    {
        /// <summary>
        /// The destination state name when going through transition of state via this edge. State transition internally is implemented as a tool call of LLM, and a tool call with name "transition_to_{destination_state_name}" will get created. Feel free to reference it inside the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination_state_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DestinationStateName { get; set; } = default!;

        /// <summary>
        /// Describes what's the transition and at what time / criteria should this transition happen.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ToolParameter? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateEdge" /> class.
        /// </summary>
        /// <param name="destinationStateName">
        /// The destination state name when going through transition of state via this edge. State transition internally is implemented as a tool call of LLM, and a tool call with name "transition_to_{destination_state_name}" will get created. Feel free to reference it inside the prompt.
        /// </param>
        /// <param name="description">
        /// Describes what's the transition and at what time / criteria should this transition happen.
        /// </param>
        /// <param name="parameters">
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </param>
        public StateEdge(
            string destinationStateName,
            string description,
            global::G.ToolParameter? parameters)
        {
            this.DestinationStateName = destinationStateName ?? throw new global::System.ArgumentNullException(nameof(destinationStateName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateEdge" /> class.
        /// </summary>
        public StateEdge()
        {
        }
    }
}