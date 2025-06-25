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
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ToolsItem> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentToolsItem> AgentTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("others")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SecretDependencyType> Others { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public global::System.Collections.Generic.IList<global::G.DependentPhoneNumberIdentifier>? PhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIStoredSecretDependencies" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="agentTools"></param>
        /// <param name="others"></param>
        /// <param name="phoneNumbers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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