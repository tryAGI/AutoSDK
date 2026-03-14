//HintName: G.Models.EagerReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reference to a value resolved from the session context at the start of each turn. Resolution occurs when a new message is submitted to the agent session, before any LLM processing begins. The resolved value remains constant throughout the turn and is not re-evaluated during the agent's response or subsequent tool calls within the same turn.
    /// </summary>
    public sealed partial class EagerReference
    {
        /// <summary>
        /// A dot-notation path to the value in the session context.<br/>
        /// Example: session.metadata.filters.user_access
        /// </summary>
        /// <example>session.metadata.filters.user_access</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("$ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EagerReference" /> class.
        /// </summary>
        /// <param name="x_ref">
        /// A dot-notation path to the value in the session context.<br/>
        /// Example: session.metadata.filters.user_access
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EagerReference(
            string x_ref)
        {
            this.x_ref = x_ref ?? throw new global::System.ArgumentNullException(nameof(x_ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EagerReference" /> class.
        /// </summary>
        public EagerReference()
        {
        }
    }
}