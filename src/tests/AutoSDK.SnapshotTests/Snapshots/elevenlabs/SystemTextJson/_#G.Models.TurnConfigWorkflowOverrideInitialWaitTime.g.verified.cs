//HintName: G.Models.TurnConfigWorkflowOverrideInitialWaitTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
    /// </summary>
    public sealed partial class TurnConfigWorkflowOverrideInitialWaitTime
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}