//HintName: G.Models.ConvAIStoredSecretDependencies.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvAIStoredSecretDependencies
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolsItem> Tools { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentToolsItem> AgentTools { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("others", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SecretDependencyType> Others { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_numbers")]
        public global::System.Collections.Generic.IList<global::G.DependentPhoneNumberIdentifier>? PhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIStoredSecretDependencies" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="agentTools"></param>
        /// <param name="others"></param>
        /// <param name="phoneNumbers"></param>
        public ConvAIStoredSecretDependencies(
            global::System.Collections.Generic.IList<global::G.ToolsItem> tools,
            global::System.Collections.Generic.IList<global::G.AgentToolsItem> agentTools,
            global::System.Collections.Generic.IList<global::G.SecretDependencyType> others,
            global::System.Collections.Generic.IList<global::G.DependentPhoneNumberIdentifier>? phoneNumbers)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.AgentTools = agentTools ?? throw new global::System.ArgumentNullException(nameof(agentTools));
            this.Others = others ?? throw new global::System.ArgumentNullException(nameof(others));
            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIStoredSecretDependencies" /> class.
        /// </summary>
        public ConvAIStoredSecretDependencies()
        {
        }
    }
}