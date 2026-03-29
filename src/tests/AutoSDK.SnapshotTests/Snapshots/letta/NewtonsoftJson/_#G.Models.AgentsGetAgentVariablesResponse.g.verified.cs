//HintName: G.Models.AgentsGetAgentVariablesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsGetAgentVariablesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Variables { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentVariablesResponse" /> class.
        /// </summary>
        /// <param name="variables"></param>
        public AgentsGetAgentVariablesResponse(
            global::System.Collections.Generic.Dictionary<string, string> variables)
        {
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentVariablesResponse" /> class.
        /// </summary>
        public AgentsGetAgentVariablesResponse()
        {
        }
    }
}