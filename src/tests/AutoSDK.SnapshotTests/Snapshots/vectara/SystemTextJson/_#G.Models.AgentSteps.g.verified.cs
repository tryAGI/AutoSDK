//HintName: G.Models.AgentSteps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of additional named steps keyed by step name.<br/>
    /// The first_step can transition to steps defined here via next_steps.<br/>
    /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
    /// </summary>
    public sealed partial class AgentSteps
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}