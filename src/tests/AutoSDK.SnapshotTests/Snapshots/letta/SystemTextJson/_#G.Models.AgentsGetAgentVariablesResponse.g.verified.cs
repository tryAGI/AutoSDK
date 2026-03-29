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
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentVariablesResponse" /> class.
        /// </summary>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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