//HintName: G.Models.CreateAgentRequestSteps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of named steps keyed by step name.<br/>
    /// Steps can transition to other steps defined here via next_steps.<br/>
    /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
    /// </summary>
    public sealed partial class CreateAgentRequestSteps
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}