//HintName: G.Models.AgentsGetAgentVariablesResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsGetAgentVariablesResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentsGetAgentVariablesResponseMessageJsonConverter))]
        public global::G.AgentsGetAgentVariablesResponseMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentVariablesResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        public AgentsGetAgentVariablesResponse2(
            global::G.AgentsGetAgentVariablesResponseMessage message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentVariablesResponse2" /> class.
        /// </summary>
        public AgentsGetAgentVariablesResponse2()
        {
        }
    }
}