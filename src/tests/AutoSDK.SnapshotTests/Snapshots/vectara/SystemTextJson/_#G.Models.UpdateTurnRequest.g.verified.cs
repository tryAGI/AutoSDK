//HintName: G.Models.UpdateTurnRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update a specific turn (message exchange) within a chat conversation.
    /// </summary>
    public sealed partial class UpdateTurnRequest
    {
        /// <summary>
        /// Indicates whether to disable a turn. It will disable this turn and all subsequent turns.<br/>
        /// Enabling a turn is not implemented.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTurnRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates whether to disable a turn. It will disable this turn and all subsequent turns.<br/>
        /// Enabling a turn is not implemented.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTurnRequest(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTurnRequest" /> class.
        /// </summary>
        public UpdateTurnRequest()
        {
        }
    }
}