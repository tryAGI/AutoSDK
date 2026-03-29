//HintName: G.Models.ChatAssistantOverrides.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAssistantOverrides
    {
        /// <summary>
        /// Variable values for template substitution<br/>
        /// Example: {"name":"John","company":"ACME Corp"}
        /// </summary>
        /// <example>{"name":"John","company":"ACME Corp"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableValues")]
        public object? VariableValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantOverrides" /> class.
        /// </summary>
        /// <param name="variableValues">
        /// Variable values for template substitution<br/>
        /// Example: {"name":"John","company":"ACME Corp"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAssistantOverrides(
            object? variableValues)
        {
            this.VariableValues = variableValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantOverrides" /> class.
        /// </summary>
        public ChatAssistantOverrides()
        {
        }
    }
}